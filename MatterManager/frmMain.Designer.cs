﻿namespace MatterManager
{
    partial class frmMain
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
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.tsmSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.今日督办toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.新增事务ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.事务管理ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.牵头人toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.退出程序ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询打印toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSystem,
            this.帮助ToolStripMenuItem});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(1008, 25);
            this.mnuMain.TabIndex = 0;
            this.mnuMain.Text = "menuStrip1";
            // 
            // tsmSystem
            // 
            this.tsmSystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.今日督办toolStripMenuItem1,
            this.toolStripSeparator2,
            this.新增事务ToolStripMenuItem,
            this.事务管理ToolStripMenuItem1,
            this.查询打印toolStripMenuItem1,
            this.toolStripSeparator3,
            this.牵头人toolStripMenuItem1,
            this.toolStripSeparator1,
            this.退出程序ToolStripMenuItem});
            this.tsmSystem.Name = "tsmSystem";
            this.tsmSystem.Size = new System.Drawing.Size(44, 21);
            this.tsmSystem.Text = "系统";
            // 
            // 今日督办toolStripMenuItem1
            // 
            this.今日督办toolStripMenuItem1.Name = "今日督办toolStripMenuItem1";
            this.今日督办toolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.今日督办toolStripMenuItem1.Text = "今日督办";
            this.今日督办toolStripMenuItem1.Click += new System.EventHandler(this.今日督办toolStripMenuItem1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // 新增事务ToolStripMenuItem
            // 
            this.新增事务ToolStripMenuItem.Name = "新增事务ToolStripMenuItem";
            this.新增事务ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.新增事务ToolStripMenuItem.Text = "新增事务";
            this.新增事务ToolStripMenuItem.Click += new System.EventHandler(this.新增事务ToolStripMenuItem_Click);
            // 
            // 事务管理ToolStripMenuItem1
            // 
            this.事务管理ToolStripMenuItem1.Name = "事务管理ToolStripMenuItem1";
            this.事务管理ToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.事务管理ToolStripMenuItem1.Text = "事务管理";
            this.事务管理ToolStripMenuItem1.Click += new System.EventHandler(this.事务管理ToolStripMenuItem1_Click);
            // 
            // 牵头人toolStripMenuItem1
            // 
            this.牵头人toolStripMenuItem1.Name = "牵头人toolStripMenuItem1";
            this.牵头人toolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.牵头人toolStripMenuItem1.Text = "牵头人管理";
            this.牵头人toolStripMenuItem1.Click += new System.EventHandler(this.牵头人toolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // 退出程序ToolStripMenuItem
            // 
            this.退出程序ToolStripMenuItem.Name = "退出程序ToolStripMenuItem";
            this.退出程序ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.退出程序ToolStripMenuItem.Text = "退出程序";
            this.退出程序ToolStripMenuItem.Click += new System.EventHandler(this.退出程序ToolStripMenuItem_Click);
            // 
            // 查询打印toolStripMenuItem1
            // 
            this.查询打印toolStripMenuItem1.Name = "查询打印toolStripMenuItem1";
            this.查询打印toolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.查询打印toolStripMenuItem1.Text = "查询/打印";
            this.查询打印toolStripMenuItem1.Click += new System.EventHandler(this.查询打印toolStripMenuItem1_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(149, 6);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.mnuMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuMain;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MatterManager";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem tsmSystem;
        private System.Windows.Forms.ToolStripMenuItem 新增事务ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 事务管理ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 退出程序ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 牵头人toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 今日督办toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 查询打印toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
    }
}

