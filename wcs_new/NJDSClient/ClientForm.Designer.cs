﻿namespace NJDSClient
{
    partial class ClientForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabelConnect = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabelTime = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabelLogin = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabelVersion = new System.Windows.Forms.ToolStripLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.刷新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.登录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.注销登录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户登录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonSendRun = new System.Windows.Forms.Button();
            this.buttonStartTask = new System.Windows.Forms.Button();
            this.timerFunc = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxOutput = new System.Windows.Forms.ListBox();
            this.buttonCallAGv = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCurTar = new System.Windows.Forms.TextBox();
            this.textBoxNextTars = new System.Windows.Forms.TextBox();
            this.buttonAlter = new System.Windows.Forms.Button();
            this.buttonManSend = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelLogo = new System.Windows.Forms.Label();
            this.buttonBackPoint = new System.Windows.Forms.Button();
            this.buttonTaskDone = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageMap = new System.Windows.Forms.TabPage();
            this.panelMap = new System.Windows.Forms.Panel();
            this.tabPageStation = new System.Windows.Forms.TabPage();
            this.panelBtn = new System.Windows.Forms.Panel();
            this.系统初始化ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageMap.SuspendLayout();
            this.tabPageStation.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelConnect,
            this.toolStripSeparator3,
            this.toolStripLabelTime,
            this.toolStripSeparator1,
            this.toolStripLabelLogin,
            this.toolStripSeparator2,
            this.toolStripLabelVersion});
            this.toolStrip1.Location = new System.Drawing.Point(0, 420);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(907, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabelConnect
            // 
            this.toolStripLabelConnect.Name = "toolStripLabelConnect";
            this.toolStripLabelConnect.Size = new System.Drawing.Size(56, 22);
            this.toolStripLabelConnect.Text = "连接状态";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabelTime
            // 
            this.toolStripLabelTime.Name = "toolStripLabelTime";
            this.toolStripLabelTime.Size = new System.Drawing.Size(56, 22);
            this.toolStripLabelTime.Text = "系统时间";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabelLogin
            // 
            this.toolStripLabelLogin.Name = "toolStripLabelLogin";
            this.toolStripLabelLogin.Size = new System.Drawing.Size(56, 22);
            this.toolStripLabelLogin.Text = "用户状态";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabelVersion
            // 
            this.toolStripLabelVersion.Name = "toolStripLabelVersion";
            this.toolStripLabelVersion.Size = new System.Drawing.Size(44, 22);
            this.toolStripLabelVersion.Text = "版本号";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.刷新ToolStripMenuItem,
            this.登录ToolStripMenuItem,
            this.系统初始化ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(907, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 刷新ToolStripMenuItem
            // 
            this.刷新ToolStripMenuItem.Name = "刷新ToolStripMenuItem";
            this.刷新ToolStripMenuItem.Size = new System.Drawing.Size(60, 21);
            this.刷新ToolStripMenuItem.Text = "刷新(&R)";
            this.刷新ToolStripMenuItem.Click += new System.EventHandler(this.刷新ToolStripMenuItem_Click);
            // 
            // 登录ToolStripMenuItem
            // 
            this.登录ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.注销登录ToolStripMenuItem,
            this.用户登录ToolStripMenuItem});
            this.登录ToolStripMenuItem.Name = "登录ToolStripMenuItem";
            this.登录ToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.登录ToolStripMenuItem.Text = "用户(&U)";
            // 
            // 注销登录ToolStripMenuItem
            // 
            this.注销登录ToolStripMenuItem.Name = "注销登录ToolStripMenuItem";
            this.注销登录ToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.注销登录ToolStripMenuItem.Text = "注销登录(&C)";
            this.注销登录ToolStripMenuItem.Click += new System.EventHandler(this.注销登录ToolStripMenuItem_Click);
            // 
            // 用户登录ToolStripMenuItem
            // 
            this.用户登录ToolStripMenuItem.Name = "用户登录ToolStripMenuItem";
            this.用户登录ToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.用户登录ToolStripMenuItem.Text = "用户登录(&L)";
            this.用户登录ToolStripMenuItem.Click += new System.EventHandler(this.用户登录ToolStripMenuItem_Click);
            // 
            // buttonSendRun
            // 
            this.buttonSendRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSendRun.BackColor = System.Drawing.Color.Teal;
            this.buttonSendRun.Location = new System.Drawing.Point(478, 352);
            this.buttonSendRun.Name = "buttonSendRun";
            this.buttonSendRun.Size = new System.Drawing.Size(75, 65);
            this.buttonSendRun.TabIndex = 3;
            this.buttonSendRun.Text = "启动AGV";
            this.buttonSendRun.UseVisualStyleBackColor = false;
            this.buttonSendRun.Click += new System.EventHandler(this.buttonSendRun_Click);
            // 
            // buttonStartTask
            // 
            this.buttonStartTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStartTask.BackColor = System.Drawing.Color.Teal;
            this.buttonStartTask.Location = new System.Drawing.Point(572, 352);
            this.buttonStartTask.Name = "buttonStartTask";
            this.buttonStartTask.Size = new System.Drawing.Size(75, 65);
            this.buttonStartTask.TabIndex = 4;
            this.buttonStartTask.Text = "派发任务";
            this.buttonStartTask.UseVisualStyleBackColor = false;
            this.buttonStartTask.Click += new System.EventHandler(this.buttonStartTask_Click);
            // 
            // timerFunc
            // 
            this.timerFunc.Interval = 500;
            this.timerFunc.Tick += new System.EventHandler(this.timerFunc_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.listBoxOutput);
            this.groupBox1.Location = new System.Drawing.Point(3, 338);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 79);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "系统信息";
            // 
            // listBoxOutput
            // 
            this.listBoxOutput.BackColor = System.Drawing.SystemColors.Menu;
            this.listBoxOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxOutput.FormattingEnabled = true;
            this.listBoxOutput.ItemHeight = 12;
            this.listBoxOutput.Location = new System.Drawing.Point(3, 17);
            this.listBoxOutput.Name = "listBoxOutput";
            this.listBoxOutput.Size = new System.Drawing.Size(358, 59);
            this.listBoxOutput.TabIndex = 0;
            // 
            // buttonCallAGv
            // 
            this.buttonCallAGv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCallAGv.BackColor = System.Drawing.Color.Teal;
            this.buttonCallAGv.Location = new System.Drawing.Point(384, 352);
            this.buttonCallAGv.Name = "buttonCallAGv";
            this.buttonCallAGv.Size = new System.Drawing.Size(75, 65);
            this.buttonCallAGv.TabIndex = 6;
            this.buttonCallAGv.Text = "呼叫AGV";
            this.buttonCallAGv.UseVisualStyleBackColor = false;
            this.buttonCallAGv.Click += new System.EventHandler(this.buttonCallAGv_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(2, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "本站点:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(317, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "目的地:";
            // 
            // textBoxCurTar
            // 
            this.textBoxCurTar.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxCurTar.ForeColor = System.Drawing.Color.Red;
            this.textBoxCurTar.Location = new System.Drawing.Point(82, 87);
            this.textBoxCurTar.Name = "textBoxCurTar";
            this.textBoxCurTar.ReadOnly = true;
            this.textBoxCurTar.Size = new System.Drawing.Size(106, 29);
            this.textBoxCurTar.TabIndex = 9;
            // 
            // textBoxNextTars
            // 
            this.textBoxNextTars.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxNextTars.ForeColor = System.Drawing.Color.Red;
            this.textBoxNextTars.Location = new System.Drawing.Point(398, 87);
            this.textBoxNextTars.Name = "textBoxNextTars";
            this.textBoxNextTars.ReadOnly = true;
            this.textBoxNextTars.Size = new System.Drawing.Size(403, 29);
            this.textBoxNextTars.TabIndex = 10;
            // 
            // buttonAlter
            // 
            this.buttonAlter.Location = new System.Drawing.Point(193, 91);
            this.buttonAlter.Name = "buttonAlter";
            this.buttonAlter.Size = new System.Drawing.Size(70, 23);
            this.buttonAlter.TabIndex = 11;
            this.buttonAlter.Text = "修  改";
            this.buttonAlter.UseVisualStyleBackColor = true;
            this.buttonAlter.Click += new System.EventHandler(this.buttonAlter_Click);
            // 
            // buttonManSend
            // 
            this.buttonManSend.Location = new System.Drawing.Point(806, 91);
            this.buttonManSend.Name = "buttonManSend";
            this.buttonManSend.Size = new System.Drawing.Size(70, 23);
            this.buttonManSend.TabIndex = 12;
            this.buttonManSend.Text = "自动模式";
            this.buttonManSend.UseVisualStyleBackColor = true;
            this.buttonManSend.Click += new System.EventHandler(this.buttonManSend_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.labelLogo);
            this.panel1.Location = new System.Drawing.Point(3, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(905, 55);
            this.panel1.TabIndex = 13;
            // 
            // labelLogo
            // 
            this.labelLogo.AutoSize = true;
            this.labelLogo.Font = new System.Drawing.Font("华文楷体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelLogo.Location = new System.Drawing.Point(375, 10);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(151, 36);
            this.labelLogo.TabIndex = 0;
            this.labelLogo.Text = " 微科创新";
            // 
            // buttonBackPoint
            // 
            this.buttonBackPoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBackPoint.BackColor = System.Drawing.Color.Teal;
            this.buttonBackPoint.Location = new System.Drawing.Point(666, 352);
            this.buttonBackPoint.Name = "buttonBackPoint";
            this.buttonBackPoint.Size = new System.Drawing.Size(75, 65);
            this.buttonBackPoint.TabIndex = 14;
            this.buttonBackPoint.Text = "返回待命";
            this.buttonBackPoint.UseVisualStyleBackColor = false;
            this.buttonBackPoint.Click += new System.EventHandler(this.buttonBackPoint_Click);
            // 
            // buttonTaskDone
            // 
            this.buttonTaskDone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTaskDone.BackColor = System.Drawing.Color.Teal;
            this.buttonTaskDone.Location = new System.Drawing.Point(760, 352);
            this.buttonTaskDone.Name = "buttonTaskDone";
            this.buttonTaskDone.Size = new System.Drawing.Size(75, 65);
            this.buttonTaskDone.TabIndex = 15;
            this.buttonTaskDone.Text = "确认完成";
            this.buttonTaskDone.UseVisualStyleBackColor = false;
            this.buttonTaskDone.Click += new System.EventHandler(this.buttonTaskDone_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageMap);
            this.tabControl1.Controls.Add(this.tabPageStation);
            this.tabControl1.Font = new System.Drawing.Font("宋体", 16F);
            this.tabControl1.Location = new System.Drawing.Point(6, 120);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(901, 210);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPageMap
            // 
            this.tabPageMap.Controls.Add(this.panelMap);
            this.tabPageMap.Location = new System.Drawing.Point(4, 31);
            this.tabPageMap.Name = "tabPageMap";
            this.tabPageMap.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMap.Size = new System.Drawing.Size(893, 175);
            this.tabPageMap.TabIndex = 1;
            this.tabPageMap.Text = "地图展示";
            this.tabPageMap.UseVisualStyleBackColor = true;
            // 
            // panelMap
            // 
            this.panelMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMap.Location = new System.Drawing.Point(3, 3);
            this.panelMap.Name = "panelMap";
            this.panelMap.Size = new System.Drawing.Size(887, 169);
            this.panelMap.TabIndex = 0;
            // 
            // tabPageStation
            // 
            this.tabPageStation.Controls.Add(this.panelBtn);
            this.tabPageStation.Location = new System.Drawing.Point(4, 31);
            this.tabPageStation.Name = "tabPageStation";
            this.tabPageStation.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStation.Size = new System.Drawing.Size(893, 175);
            this.tabPageStation.TabIndex = 0;
            this.tabPageStation.Text = "配送站点";
            this.tabPageStation.UseVisualStyleBackColor = true;
            // 
            // panelBtn
            // 
            this.panelBtn.AutoScroll = true;
            this.panelBtn.BackColor = System.Drawing.Color.LightBlue;
            this.panelBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBtn.Font = new System.Drawing.Font("宋体", 9F);
            this.panelBtn.Location = new System.Drawing.Point(3, 3);
            this.panelBtn.Name = "panelBtn";
            this.panelBtn.Size = new System.Drawing.Size(887, 169);
            this.panelBtn.TabIndex = 1;
            this.panelBtn.SizeChanged += new System.EventHandler(this.panelBtn_SizeChanged);
            // 
            // 系统初始化ToolStripMenuItem
            // 
            this.系统初始化ToolStripMenuItem.Name = "系统初始化ToolStripMenuItem";
            this.系统初始化ToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.系统初始化ToolStripMenuItem.Text = "系统初始化";
            this.系统初始化ToolStripMenuItem.Click += new System.EventHandler(this.系统初始化ToolStripMenuItem_Click);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 445);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.buttonTaskDone);
            this.Controls.Add(this.buttonBackPoint);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonManSend);
            this.Controls.Add(this.buttonAlter);
            this.Controls.Add(this.textBoxNextTars);
            this.Controls.Add(this.textBoxCurTar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCallAGv);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonStartTask);
            this.Controls.Add(this.buttonSendRun);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ClientForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientForm_FormClosing);
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.SizeChanged += new System.EventHandler(this.ClientForm_SizeChanged);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageMap.ResumeLayout(false);
            this.tabPageStation.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 刷新ToolStripMenuItem;
        private System.Windows.Forms.Button buttonSendRun;
        private System.Windows.Forms.Button buttonStartTask;
        private System.Windows.Forms.Timer timerFunc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBoxOutput;
        private System.Windows.Forms.ToolStripLabel toolStripLabelConnect;
        private System.Windows.Forms.ToolStripLabel toolStripLabelTime;
        private System.Windows.Forms.Button buttonCallAGv;
        private System.Windows.Forms.ToolStripLabel toolStripLabelVersion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCurTar;
        private System.Windows.Forms.TextBox textBoxNextTars;
        private System.Windows.Forms.Button buttonAlter;
        private System.Windows.Forms.Button buttonManSend;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelLogo;
        private System.Windows.Forms.Button buttonBackPoint;
        private System.Windows.Forms.Button buttonTaskDone;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageStation;
        private System.Windows.Forms.Panel panelBtn;
        private System.Windows.Forms.TabPage tabPageMap;
        private System.Windows.Forms.Panel panelMap;
        private System.Windows.Forms.ToolStripMenuItem 登录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 注销登录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户登录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabelLogin;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 系统初始化ToolStripMenuItem;
    }
}

