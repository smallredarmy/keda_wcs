﻿using Gfx.GfxDataManagerServer;
using GfxCommonInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace NJDSClient
{
    /// <summary>
    /// 操作类型
    /// </summary>
    public enum EnumOper
    { 
        无动作,
        取货,
        放货
    }

    /// <summary>
    /// 执行任务对象
    /// </summary>
    public class F_ExcTask
    {
        string _id = Guid.NewGuid().ToString();
        
        /// <summary>
        /// 任务起点
        /// </summary>
        string _startSite = "";

        /// <summary>
        /// 任务终点
        /// </summary>
        string _endSite = "null";

        /// <summary>
        /// 操作PLC对象
        /// </summary>
        F_PLCLine _plc = null;

        /// <summary>
        /// 操作类型
        /// </summary>
        EnumOper _operType = EnumOper.无动作;

        /// <summary>
        /// 操作AGV对象
        /// </summary>
        F_AGV _agv = null;

        /// <summary>
        /// 是否已经完成
        /// </summary>
        bool _isSuc = false;

        /// <summary>
        /// 此次任务的调度结果
        /// </summary>
        DispatchBackMember _taskDispatch = null;

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }

        /// <summary>
        /// 操作PLC对象
        /// </summary>
        public F_PLCLine Plc
        {
            get { return _plc; }
        }

        /// <summary>
        /// 是否已经完成
        /// </summary>
        public bool IsSuc
        {
            get { return _isSuc; }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="plc"></param>
        /// <param name="oper"></param>
        public F_ExcTask(F_PLCLine plc,EnumOper oper,string startSite,string endSite)
        {
            _plc = plc;

            _operType = oper;

            _startSite = startSite;

            _endSite = endSite;
        }

        /// <summary>
        /// 任务完成
        /// </summary>
        private void ISetTaskSuc()
        {
            if (_plc != null) { _plc.IsLock = false; }

            if (_taskDispatch != null) { if (JTWcfHelper.WcfMainHelper.CtrDispatch(_taskDispatch.DisGuid, DisOrderCtrTypeEnum.Stop)) { _isSuc = true; } }
            else { _isSuc = true; }
        }

        /// <summary>
        /// 事务处理
        /// </summary>
        public void DoWork()
        {
            if (_isSuc) { return; }

            _taskDispatch = JTWcfHelper.WcfMainHelper.GetDispatch(Id);

            if (_taskDispatch == null)
            {
                DispatchOrderObj dis = new DispatchOrderObj(); dis.DisGuid = Id;

                dis.EndSite = _endSite;

                if (!string.IsNullOrEmpty(_startSite)) { dis.StartSiteList.Add(_startSite); }

                string back = "";

                JTWcfHelper.WcfMainHelper.StartDispatch(dis, out back);
            }
            else
            {
                ///确定此时任务的AGV
                if (_agv == null) { _agv = new F_AGV(_taskDispatch.DisDevId); }

                ///此次调度任务已经完成
                if (_taskDispatch.OrderStatue == ResultTypeEnum.Suc)
                {
                    if (_operType == EnumOper.取货)
                    {
                        ///当前AGV的到达的地标 与 棍台绑定地标一致
                        if (_agv.Site == _plc.Site)
                        {
                            if (_plc.Sta_Material == EnumSta_Material.有货 && _agv.Sta_Material == EnumSta_Material.无货)
                            {
                                _agv.SendOrdr(EnumType.上料操作, EnumPara.反向启动);

                                _plc.SendOrdr(EnumType.下料操作, EnumPara.正向启动);
                            }

                            if (_plc.Sta_Material == EnumSta_Material.无货 && _agv.Sta_Material == EnumSta_Material.有货)
                            {
                                _agv.SendOrdr(EnumType.上料操作, EnumPara.辊台停止);

                                _plc.SendOrdr(EnumType.下料操作, EnumPara.辊台停止);

                                if (_plc.Sta_Monitor == EnumSta_Monitor.停止)
                                {
                                    ISetTaskSuc();
                                }
                            }
                        }
                    }
                    else if (_operType == EnumOper.放货)
                    {
                        ///当前AGV的到达的地标 与 棍台绑定地标一致
                        if (_agv.Site == _plc.Site)
                        {

                        }
                    }
                    else if (_operType == EnumOper.无动作)
                    {
                        ISetTaskSuc();
                    }
                }
            }
        }
    }

    /// <summary>
    /// 任务管理器
    /// </summary>
    public class F_ExcTaskManager
    {
        object _ans = new object();

        List<F_ExcTask> _taskList = new List<F_ExcTask>();

        /// <summary>
        /// 线程
        /// </summary>
        Thread _thread = null;

        /// <summary>
        /// 构造函数
        /// </summary>
        public F_ExcTaskManager()
        {
            _thread = new Thread(ThreadFunc);

            _thread.Name = "任务处理线程";

            _thread.IsBackground = true;

            _thread.Start();
        }

        /// <summary>
        /// 事务线程
        /// </summary>
        private void ThreadFunc()
        {
            List<F_ExcTask> taskList = new List<F_ExcTask>();

            while (true)
            {
                Thread.Sleep(500);

                try
                {
                    lock (_ans) { taskList.Clear(); taskList.AddRange(_taskList); }

                    foreach (var item in taskList)
                    {
                        item.DoWork();

                        if (item.IsSuc) { IDeletTask(item.Id); }
                    }
                }
                catch { }
            }
        }

        /// <summary>
        /// 开始一个新的操作任务
        /// </summary>
        /// <param name="task"></param>
        /// <returns></returns>
        public bool IStartTask(F_ExcTask task)
        {
            lock (_ans)
            {
                F_ExcTask exit = _taskList.Find(c => { return (c.Plc == task.Plc && task.Plc != null) || c.Id == task.Id; });

                if (exit == null) { _taskList.Add(task); return true; }
            }

            return false;
        }

        /// <summary>
        /// 删除一个任务
        /// </summary>
        /// <param name="Id"></param>
        public void IDeletTask(string Id)
        {
            lock (_ans)
            {
                F_ExcTask exit = _taskList.Find(c => { return c.Id == Id; });

                if (exit != null && _taskList.Contains(exit)) 
                { 
                    _taskList.Remove(exit); 
                }
            }
        }
    }
}
