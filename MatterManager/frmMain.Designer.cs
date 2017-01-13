namespace MatterManager
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
            this.新增事务ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.来自公文ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.来自会议ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.来自事件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.事务管理ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.退出程序ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSystem});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(1008, 25);
            this.mnuMain.TabIndex = 0;
            this.mnuMain.Text = "menuStrip1";
            // 
            // tsmSystem
            // 
            this.tsmSystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增事务ToolStripMenuItem,
            this.事务管理ToolStripMenuItem1,
            this.toolStripSeparator1,
            this.退出程序ToolStripMenuItem});
            this.tsmSystem.Name = "tsmSystem";
            this.tsmSystem.Size = new System.Drawing.Size(44, 21);
            this.tsmSystem.Text = "系统";
            // 
            // 新增事务ToolStripMenuItem
            // 
            this.新增事务ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.来自公文ToolStripMenuItem,
            this.来自会议ToolStripMenuItem,
            this.来自事件ToolStripMenuItem});
            this.新增事务ToolStripMenuItem.Name = "新增事务ToolStripMenuItem";
            this.新增事务ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.新增事务ToolStripMenuItem.Text = "新增事务";
            // 
            // 来自公文ToolStripMenuItem
            // 
            this.来自公文ToolStripMenuItem.Name = "来自公文ToolStripMenuItem";
            this.来自公文ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.来自公文ToolStripMenuItem.Text = "来自公文";
            this.来自公文ToolStripMenuItem.Click += new System.EventHandler(this.来自公文ToolStripMenuItem_Click);
            // 
            // 来自会议ToolStripMenuItem
            // 
            this.来自会议ToolStripMenuItem.Name = "来自会议ToolStripMenuItem";
            this.来自会议ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.来自会议ToolStripMenuItem.Text = "来自会议";
            // 
            // 来自事件ToolStripMenuItem
            // 
            this.来自事件ToolStripMenuItem.Name = "来自事件ToolStripMenuItem";
            this.来自事件ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.来自事件ToolStripMenuItem.Text = "来自事件";
            // 
            // 事务管理ToolStripMenuItem1
            // 
            this.事务管理ToolStripMenuItem1.Name = "事务管理ToolStripMenuItem1";
            this.事务管理ToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.事务管理ToolStripMenuItem1.Text = "事务管理";
            // 
            // 退出程序ToolStripMenuItem
            // 
            this.退出程序ToolStripMenuItem.Name = "退出程序ToolStripMenuItem";
            this.退出程序ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.退出程序ToolStripMenuItem.Text = "退出程序";
            this.退出程序ToolStripMenuItem.Click += new System.EventHandler(this.退出程序ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
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
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem tsmSystem;
        private System.Windows.Forms.ToolStripMenuItem 新增事务ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 来自公文ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 来自会议ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 来自事件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 事务管理ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 退出程序ToolStripMenuItem;
    }
}

