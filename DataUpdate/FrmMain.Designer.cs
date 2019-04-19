﻿namespace DataUpdate
{
    partial class FrmMain
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.待上传数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.已上传数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.上传失败记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除上传失败记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.标定自检上传记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据库升级ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_CarNum = new System.Windows.Forms.TextBox();
            this.button_SeachByCarNum = new System.Windows.Forms.Button();
            this.button_UpdateByMan = new System.Windows.Forms.Button();
            this.dataGridView_Ready_And_Failed = new System.Windows.Forms.DataGridView();
            this.dataGridView_AlreadyUpload = new System.Windows.Forms.DataGridView();
            this.timerGetWaitCarList = new System.Windows.Forms.Timer(this.components);
            this.timerUploadTestData = new System.Windows.Forms.Timer(this.components);
            this.timerBdZjUpdate = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tSSL_Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataGridView_BDZJ = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.上传该条数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除该条数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView_UploadFailed = new System.Windows.Forms.DataGridView();
            this.timerRefreshFaileData = new System.Windows.Forms.Timer(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripProgressBar2 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripProgressBar3 = new System.Windows.Forms.ToolStripProgressBar();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Ready_And_Failed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AlreadyUpload)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_BDZJ)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_UploadFailed)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.待上传数据ToolStripMenuItem,
            this.已上传数据ToolStripMenuItem,
            this.上传失败记录ToolStripMenuItem,
            this.删除上传失败记录ToolStripMenuItem,
            this.标定自检上传记录ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1039, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 待上传数据ToolStripMenuItem
            // 
            this.待上传数据ToolStripMenuItem.Name = "待上传数据ToolStripMenuItem";
            this.待上传数据ToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.待上传数据ToolStripMenuItem.Text = "待上传车辆";
            this.待上传数据ToolStripMenuItem.Click += new System.EventHandler(this.待上传数据ToolStripMenuItem_Click);
            // 
            // 已上传数据ToolStripMenuItem
            // 
            this.已上传数据ToolStripMenuItem.Name = "已上传数据ToolStripMenuItem";
            this.已上传数据ToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.已上传数据ToolStripMenuItem.Text = "已上传车辆";
            this.已上传数据ToolStripMenuItem.Click += new System.EventHandler(this.已上传数据ToolStripMenuItem_Click);
            // 
            // 上传失败记录ToolStripMenuItem
            // 
            this.上传失败记录ToolStripMenuItem.Name = "上传失败记录ToolStripMenuItem";
            this.上传失败记录ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.上传失败记录ToolStripMenuItem.Text = "上传失败车辆";
            this.上传失败记录ToolStripMenuItem.Click += new System.EventHandler(this.上传失败记录ToolStripMenuItem_Click);
            // 
            // 删除上传失败记录ToolStripMenuItem
            // 
            this.删除上传失败记录ToolStripMenuItem.Name = "删除上传失败记录ToolStripMenuItem";
            this.删除上传失败记录ToolStripMenuItem.Size = new System.Drawing.Size(116, 21);
            this.删除上传失败记录ToolStripMenuItem.Text = "删除上传失败记录";
            this.删除上传失败记录ToolStripMenuItem.Click += new System.EventHandler(this.删除上传失败记录ToolStripMenuItem_Click);
            // 
            // 标定自检上传记录ToolStripMenuItem
            // 
            this.标定自检上传记录ToolStripMenuItem.Name = "标定自检上传记录ToolStripMenuItem";
            this.标定自检上传记录ToolStripMenuItem.Size = new System.Drawing.Size(116, 21);
            this.标定自检上传记录ToolStripMenuItem.Text = "标定自检上传记录";
            this.标定自检上传记录ToolStripMenuItem.Click += new System.EventHandler(this.标定自检上传记录ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.数据库升级ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 数据库升级ToolStripMenuItem
            // 
            this.数据库升级ToolStripMenuItem.Name = "数据库升级ToolStripMenuItem";
            this.数据库升级ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.数据库升级ToolStripMenuItem.Text = "数据库升级";
            this.数据库升级ToolStripMenuItem.Click += new System.EventHandler(this.数据库升级ToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(820, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "号牌：";
            // 
            // textBox_CarNum
            // 
            this.textBox_CarNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_CarNum.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_CarNum.Location = new System.Drawing.Point(864, 4);
            this.textBox_CarNum.Name = "textBox_CarNum";
            this.textBox_CarNum.Size = new System.Drawing.Size(82, 21);
            this.textBox_CarNum.TabIndex = 2;
            this.textBox_CarNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_SeachByCarNum
            // 
            this.button_SeachByCarNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_SeachByCarNum.Location = new System.Drawing.Point(952, 2);
            this.button_SeachByCarNum.Name = "button_SeachByCarNum";
            this.button_SeachByCarNum.Size = new System.Drawing.Size(67, 23);
            this.button_SeachByCarNum.TabIndex = 3;
            this.button_SeachByCarNum.Text = "查  询";
            this.button_SeachByCarNum.UseVisualStyleBackColor = true;
            this.button_SeachByCarNum.Click += new System.EventHandler(this.button_SeachByCarNum_Click);
            // 
            // button_UpdateByMan
            // 
            this.button_UpdateByMan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_UpdateByMan.Location = new System.Drawing.Point(738, 2);
            this.button_UpdateByMan.Name = "button_UpdateByMan";
            this.button_UpdateByMan.Size = new System.Drawing.Size(67, 23);
            this.button_UpdateByMan.TabIndex = 4;
            this.button_UpdateByMan.Text = "手动上传";
            this.button_UpdateByMan.UseVisualStyleBackColor = true;
            this.button_UpdateByMan.Visible = false;
            this.button_UpdateByMan.Click += new System.EventHandler(this.button_UpdateByMan_Click);
            // 
            // dataGridView_Ready_And_Failed
            // 
            this.dataGridView_Ready_And_Failed.AllowUserToAddRows = false;
            this.dataGridView_Ready_And_Failed.AllowUserToDeleteRows = false;
            this.dataGridView_Ready_And_Failed.AllowUserToOrderColumns = true;
            this.dataGridView_Ready_And_Failed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Ready_And_Failed.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Ready_And_Failed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Ready_And_Failed.Location = new System.Drawing.Point(510, 29);
            this.dataGridView_Ready_And_Failed.Name = "dataGridView_Ready_And_Failed";
            this.dataGridView_Ready_And_Failed.ReadOnly = true;
            this.dataGridView_Ready_And_Failed.RowHeadersWidth = 30;
            this.dataGridView_Ready_And_Failed.RowTemplate.Height = 23;
            this.dataGridView_Ready_And_Failed.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Ready_And_Failed.Size = new System.Drawing.Size(149, 507);
            this.dataGridView_Ready_And_Failed.TabIndex = 5;
            this.dataGridView_Ready_And_Failed.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Ready_And_Failed_CellClick);
            // 
            // dataGridView_AlreadyUpload
            // 
            this.dataGridView_AlreadyUpload.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_AlreadyUpload.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_AlreadyUpload.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_AlreadyUpload.Location = new System.Drawing.Point(4, 29);
            this.dataGridView_AlreadyUpload.Name = "dataGridView_AlreadyUpload";
            this.dataGridView_AlreadyUpload.RowTemplate.Height = 23;
            this.dataGridView_AlreadyUpload.Size = new System.Drawing.Size(206, 507);
            this.dataGridView_AlreadyUpload.TabIndex = 6;
            this.dataGridView_AlreadyUpload.Visible = false;
            // 
            // timerGetWaitCarList
            // 
            this.timerGetWaitCarList.Interval = 10000;
            this.timerGetWaitCarList.Tick += new System.EventHandler(this.timerGetWaitCarList_Tick);
            // 
            // timerUploadTestData
            // 
            this.timerUploadTestData.Interval = 2000;
            this.timerUploadTestData.Tick += new System.EventHandler(this.timerUploadTestData_Tick);
            // 
            // timerBdZjUpdate
            // 
            this.timerBdZjUpdate.Interval = 3000;
            this.timerBdZjUpdate.Tick += new System.EventHandler(this.timerBdZjUpdate_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSSL_Status,
            this.toolStripProgressBar1,
            this.toolStripProgressBar2,
            this.toolStripProgressBar3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1039, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tSSL_Status
            // 
            this.tSSL_Status.AutoSize = false;
            this.tSSL_Status.Name = "tSSL_Status";
            this.tSSL_Status.Size = new System.Drawing.Size(600, 17);
            this.tSSL_Status.Text = "运行状态：";
            this.tSSL_Status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridView_BDZJ
            // 
            this.dataGridView_BDZJ.AllowUserToAddRows = false;
            this.dataGridView_BDZJ.AllowUserToDeleteRows = false;
            this.dataGridView_BDZJ.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_BDZJ.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_BDZJ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_BDZJ.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView_BDZJ.Location = new System.Drawing.Point(216, 29);
            this.dataGridView_BDZJ.Name = "dataGridView_BDZJ";
            this.dataGridView_BDZJ.ReadOnly = true;
            this.dataGridView_BDZJ.RowTemplate.Height = 23;
            this.dataGridView_BDZJ.Size = new System.Drawing.Size(142, 507);
            this.dataGridView_BDZJ.TabIndex = 9;
            this.dataGridView_BDZJ.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.上传该条数据ToolStripMenuItem,
            this.删除该条数据ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(149, 48);
            // 
            // 上传该条数据ToolStripMenuItem
            // 
            this.上传该条数据ToolStripMenuItem.Name = "上传该条数据ToolStripMenuItem";
            this.上传该条数据ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.上传该条数据ToolStripMenuItem.Text = "上传该条数据";
            // 
            // 删除该条数据ToolStripMenuItem
            // 
            this.删除该条数据ToolStripMenuItem.Name = "删除该条数据ToolStripMenuItem";
            this.删除该条数据ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.删除该条数据ToolStripMenuItem.Text = "删除该条数据";
            // 
            // dataGridView_UploadFailed
            // 
            this.dataGridView_UploadFailed.AllowUserToAddRows = false;
            this.dataGridView_UploadFailed.AllowUserToDeleteRows = false;
            this.dataGridView_UploadFailed.AllowUserToOrderColumns = true;
            this.dataGridView_UploadFailed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_UploadFailed.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_UploadFailed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_UploadFailed.Location = new System.Drawing.Point(364, 29);
            this.dataGridView_UploadFailed.Name = "dataGridView_UploadFailed";
            this.dataGridView_UploadFailed.ReadOnly = true;
            this.dataGridView_UploadFailed.RowHeadersWidth = 30;
            this.dataGridView_UploadFailed.RowTemplate.Height = 23;
            this.dataGridView_UploadFailed.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_UploadFailed.Size = new System.Drawing.Size(140, 507);
            this.dataGridView_UploadFailed.TabIndex = 10;
            // 
            // timerRefreshFaileData
            // 
            this.timerRefreshFaileData.Interval = 3000;
            this.timerRefreshFaileData.Tick += new System.EventHandler(this.timerRefreshFaileData_Tick);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(628, 6);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(96, 16);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "自动刷新上传";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Maximum = 10;
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBar1.Step = 1;
            // 
            // toolStripProgressBar2
            // 
            this.toolStripProgressBar2.Maximum = 10;
            this.toolStripProgressBar2.Name = "toolStripProgressBar2";
            this.toolStripProgressBar2.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBar2.Step = 1;
            // 
            // toolStripProgressBar3
            // 
            this.toolStripProgressBar3.Maximum = 10;
            this.toolStripProgressBar3.Name = "toolStripProgressBar3";
            this.toolStripProgressBar3.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBar3.Step = 1;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 561);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dataGridView_UploadFailed);
            this.Controls.Add(this.dataGridView_BDZJ);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dataGridView_AlreadyUpload);
            this.Controls.Add(this.dataGridView_Ready_And_Failed);
            this.Controls.Add(this.button_UpdateByMan);
            this.Controls.Add(this.button_SeachByCarNum);
            this.Controls.Add(this.textBox_CarNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "金华保检测数据上传 V1.0";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.Resize += new System.EventHandler(this.FrmMain_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Ready_And_Failed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AlreadyUpload)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_BDZJ)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_UploadFailed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 待上传数据ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 已上传数据ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_CarNum;
        private System.Windows.Forms.Button button_SeachByCarNum;
        private System.Windows.Forms.Button button_UpdateByMan;
        private System.Windows.Forms.DataGridView dataGridView_Ready_And_Failed;
        private System.Windows.Forms.DataGridView dataGridView_AlreadyUpload;
        private System.Windows.Forms.Timer timerGetWaitCarList;
        private System.Windows.Forms.Timer timerUploadTestData;
        private System.Windows.Forms.Timer timerBdZjUpdate;
        private System.Windows.Forms.ToolStripMenuItem 删除上传失败记录ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tSSL_Status;
        private System.Windows.Forms.ToolStripMenuItem 标定自检上传记录ToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView_BDZJ;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 数据库升级ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 上传失败记录ToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView_UploadFailed;
        private System.Windows.Forms.Timer timerRefreshFaileData;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 上传该条数据ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除该条数据ToolStripMenuItem;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar2;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar3;
    }
}

