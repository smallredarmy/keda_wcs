﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace KEDAClient
{
    /// <summary>
    /// 业务逻辑
    /// </summary>
    public class F_Logic
    {
        /// <summary>
        /// 窑尾PLC
        /// </summary>
        F_PLCLine _plcEnd = new F_PLCLine("PLC0000001");

        /// <summary>
        /// 窑头PLC
        /// </summary>
        F_PLCLine _plcHead = new F_PLCLine("PLC0000001");

        /// <summary>
        /// 事务处理线程
        /// </summary>
        Thread _thread = null;

        private SynchronizationContext mainThreadSynContext;

        ListBox listBox;

        /// <summary>
        /// 窑尾等待区AGV是否需要充电
        /// </summary>
        public bool _PlcEndNeedCharge = false;

        /// <summary>
        /// 窑头卸载区AGV是否需要充电
        /// </summary>
        public bool _PlcHeadNeedCharge = false;

        /// <summary>
        /// 窑尾有无充电完成的AGV
        /// </summary>
        public bool _PlcEndChargeSuc = false;

        /// <summary>
        /// 窑头有无充电完成的AGV
        /// </summary>
        public bool _PlcHeadChargeSuc = false;

        /// <summary>
        /// 构造函数
        /// </summary>
        public F_Logic(SynchronizationContext context, ListBox listBoxOutput)
        {
            mainThreadSynContext = context;

            listBox = listBoxOutput;

            _plcHead.Site = ConstSetBA.窑头卸载点;

            _plcEnd.Site = ConstSetBA.窑尾装载点;

            //InitToEndWait();

            //InitToHeadWait();

            _thread = new Thread(ThreadFunc);

            _thread.IsBackground = true;

            _thread.Start();

            Thread tr = new Thread(InitToHeadWait);
            tr.IsBackground = true;
            tr.Start();

            Thread tr2 = new Thread(InitToEndWait);
            tr2.IsBackground = true;
            tr2.Start();

        }

        /// <summary>
        /// 展示服务日志到界面
        /// </summary>
        private void sendServerLog(String msg)
        {
            mainThreadSynContext.Post(new SendOrPostCallback(displayLogToUi), msg);

        }

        /// <summary>
        /// 回到主线程，操作日志框，展示日志
        /// </summary>
        private void displayLogToUi(object obj)
        {
            String msg = (String)obj;
            if (string.IsNullOrEmpty(msg)) { msg = "空消息"; }

            if (listBox.Items.Count > 200)
            {
                listBox.Items.RemoveAt(0);
            }

            listBox.Items.Add(string.Format("【{0}】：{1}", DateTime.Now.TimeOfDay.ToString(), msg));

            listBox.SelectedIndex = listBox.Items.Count - 1;
        }


        /// <summary>
        /// 
        /// </summary>
        private void ThreadFunc()
        {
            while (true)
            {
                Thread.Sleep(500);

                try
                {
                    TaskPlcEndGet();

                    TaskEndToHeadWait();

                    TaskPlcHeadPut();

                    TaskEndToEndWait();

                    PlcEndCharge();

                    PlcHeadCharge();

                    PlcEndChargeSuc();

                    PlcHeadChargeSuc();
                }
                catch { }
            }
        }

        /// <summary>
        /// 窑尾取货任务
        /// </summary>
        private void TaskPlcEndGet()
        {
            ///窑尾有货 并且 此次任务没有被响应
            if (!_plcEnd.IsLock)//&& _plcEnd.Sta_Material == EnumSta_Material.有货)
            {
                //窑尾等待区的车不需要充电且没有充电完成的车
                if (!_PlcEndNeedCharge && !_PlcEndChargeSuc)
                {
                    ///派发一个从窑尾装载等待区到窑尾装载点取货的任务
                    if (F_DataCenter.MTask.IStartTask(new F_ExcTask(_plcEnd, EnumOper.取货, ConstSetBA.窑尾装载等待区, _plcEnd.Site)))
                    {
                        _plcEnd.IsLock = true;

                        sendServerLog("任务：派发一个从窑尾装载等待区到窑尾装载点取货的任务");

                    }
                }
            }
        }

        /// <summary>
        /// 窑尾取货完成Agv从窑尾装载点到窑头卸载等待区
        /// </summary>
        private void TaskEndToHeadWait()
        {
            F_AGV agv = F_DataCenter.MDev.IGetDevOnSite(_plcEnd.Site);

            if (agv != null && agv.IsFree && agv.Sta_Material == EnumSta_Material.有货)
            {
                F_ExcTask task = new F_ExcTask(null, EnumOper.无动作, ConstSetBA.窑尾装载点, ConstSetBA.窑头卸载等待区);

                task.Id = agv.Id;

                F_DataCenter.MTask.IStartTask(task);

                sendServerLog("任务：" + agv.Id + ",窑尾取货完成Agv从窑尾装载点到窑头卸载等待区");

            }
        }


        /// <summary>
        /// 窑头放货任务
        /// </summary>
        private void TaskPlcHeadPut()
        {
            F_AGV agv = F_DataCenter.MDev.IGetDevOnSite(ConstSetBA.窑头卸载等待区);

            ///窑头无货 并且 此次任务没有被响应
            if (!_plcHead.IsLock && _plcHead.Sta_Material == EnumSta_Material.无货 && agv != null)
            {
                //窑头等待区的车不需要充电且没有充电完成的车
                if (!_PlcHeadNeedCharge && !_PlcHeadChargeSuc)
                {
                    ///派发一个从窑头卸载等待区到窑头卸载点的任务
                    if (F_DataCenter.MTask.IStartTask(new F_ExcTask(_plcHead, EnumOper.放货, ConstSetBA.窑头卸载等待区, ConstSetBA.窑头卸载点)))
                    {
                        _plcHead.IsLock = true;

                        sendServerLog("任务：派发一个从窑头卸载等待区到窑头卸载点的任务");
                    }
                }                    
            }
        }

        /// <summary>
        /// 窑头卸货完成Agv从窑头卸载点到窑尾装载等待区
        /// </summary>
        private void TaskEndToEndWait()
        {
            F_AGV agv = F_DataCenter.MDev.IGetDevOnSite(_plcHead.Site);

            if (agv != null && agv.IsFree && agv.Sta_Material == EnumSta_Material.无货)
            {
                F_ExcTask task = new F_ExcTask(null, EnumOper.无动作, ConstSetBA.窑头卸载点, ConstSetBA.窑尾装载等待区);

                task.Id = agv.Id;

                F_DataCenter.MTask.IStartTask(task);

                sendServerLog("任务:" + agv.Id + ",从窑头卸载点到窑尾装载等待区");

            }
        }

        /// <summary>
        /// 如果agv有货 回到卸载等待区
        /// </summary>
        private void InitToHeadWait()
        {
            Thread.Sleep(5000);
            List<F_AGV> agvs = F_DataCenter.MDev.IGetDevNotOnWaitSite();

            if (agvs != null)
            {
                foreach (F_AGV agv in agvs)
                {
                    F_ExcTask task = new F_ExcTask(null, EnumOper.无动作, agv.Site, ConstSetBA.窑头卸载等待区);

                    task.Id = agv.Id;

                    F_DataCenter.MTask.IStartTask(task);

                    sendServerLog("任务：" + agv.Id + ",回到窑头卸载等待区");
                }

            }
        }

        /// <summary>
        /// 如果agv没货 回到装载等待区
        /// </summary>
        private void InitToEndWait()
        {
            Thread.Sleep(5000);
            List<F_AGV> agvs = F_DataCenter.MDev.IGetDevNotLoadOnWaitSite();

            if (agvs != null)
            {
                foreach (F_AGV agv in agvs)
                {
                    F_ExcTask task = new F_ExcTask(null, EnumOper.无动作, agv.Site, ConstSetBA.窑尾装载等待区);

                    task.Id = agv.Id;

                    F_DataCenter.MTask.IStartTask(task);

                    sendServerLog("任务：" + agv.Id + ",回到窑尾装载等待区");
                }

            }
        }

        /// <summary>
        /// 窑尾等待区的AGV去充电
        /// </summary>
        private void PlcEndCharge()
        {
            F_AGV agv = F_DataCenter.MDev.IGetDevOnSite(ConstSetBA.窑尾装载等待区);
            // 让电量低于60且未充电的AGV去充电
            if (agv != null && agv.IsFree && Convert.ToInt32(agv.Electicity) < 60 &&
                    agv.ChargeStatus == "3")
            {
                _PlcEndNeedCharge = true;

                F_ExcTask task = new F_ExcTask(null, EnumOper.充电, ConstSetBA.窑尾装载等待区, ConstSetBA.充电点1);

                task.Id = agv.Id;

                F_DataCenter.MTask.IStartTask(task);

                sendServerLog("任务：" + agv.Id + ",去到窑尾充电点充电");

            }
            else
            {
                _PlcEndNeedCharge = false;

            }
        }

        /// <summary>
        /// 窑头卸载区的AGV去充电
        /// </summary>
        private void PlcHeadCharge()
        {
            F_AGV agv = F_DataCenter.MDev.IGetDevOnSite(ConstSetBA.窑头卸载等待区);
            // 让电量低于60且未充电的AGV去充电
            if (agv != null  && Convert.ToInt32(agv.Electicity) < 60 &&
                    agv.ChargeStatus == "3")
            {
                _PlcHeadNeedCharge = true;

                F_ExcTask task = new F_ExcTask(null, EnumOper.充电, ConstSetBA.窑头卸载等待区, ConstSetBA.充电点2);

                task.Id = agv.Id;

                F_DataCenter.MTask.IStartTask(task);

                sendServerLog("任务：" + agv.Id + ",去到窑头充电点充电");

            }
            else
            {
                _PlcHeadNeedCharge = false;

            }
        }

        /// <summary>
        ///窑尾充电点有充电完成的AGV
        ///优先派充电完成的车去接货
        /// </summary>
        public void PlcEndChargeSuc()
        {
            F_AGV agv = F_DataCenter.MDev.IGetDevOnSite(ConstSetBA.充电点1);
            // 有充电完成的AGV,且窑尾装载点有货
            if (agv != null && agv.ChargeStatus == "2")
            {
                if ( _plcEnd.Sta_Material == EnumSta_Material.有货)
                {
                    _PlcEndChargeSuc = true;

                    F_ExcTask task = new F_ExcTask(null, EnumOper.充电完成的车去接货, ConstSetBA.充电点1, ConstSetBA.窑尾装载点);

                    task.Id = agv.Id;

                    F_DataCenter.MTask.IStartTask(task);

                    sendServerLog("任务：" + agv.Id + ",充电完成，派充电完成的车去接货");
                }            
            }
            else
            {
                _PlcEndChargeSuc = false;
            }
        }

        /// <summary>
        ///窑头充电点有充电完成的AGV
        ///优先派充电完成的车去卸货
        /// </summary>
        public void PlcHeadChargeSuc()
        {
            F_AGV agv = F_DataCenter.MDev.IGetDevOnSite(ConstSetBA.充电点2);
            // 有充电完成的AGV,且窑头卸载点没货
            if (agv != null && agv.ChargeStatus == "2")
            {
                _PlcHeadChargeSuc = true;

                if(_plcHead.Sta_Material == EnumSta_Material.无货)
                {
                    F_ExcTask task = new F_ExcTask(null, EnumOper.充电完成的车去卸货, ConstSetBA.充电点2, ConstSetBA.窑头卸载点);

                    task.Id = agv.Id;

                    F_DataCenter.MTask.IStartTask(task);

                    sendServerLog("任务：" + agv.Id + ",充电完成，派充电完成的车去卸货");
                }
            }
            else
            {
                _PlcHeadChargeSuc = false;
            }
        }

        /// <summary>
        /// 停止事务线程
        /// </summary>
        public void ThreadStop()
        {
            if (_thread != null) _thread.Abort();

        }
    }
}
