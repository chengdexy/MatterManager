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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.tsmSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.sfdBackup = new System.Windows.Forms.SaveFileDialog();
            this.ofdRestore = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbToday = new System.Windows.Forms.ToolStripButton();
            this.tsbAddNew = new System.Windows.Forms.ToolStripButton();
            this.tsbManager = new System.Windows.Forms.ToolStripButton();
            this.tsbQueryAndPrint = new System.Windows.Forms.ToolStripButton();
            this.tsbLeadmen = new System.Windows.Forms.ToolStripButton();
            this.tsbBackupDB = new System.Windows.Forms.ToolStripButton();
            this.tsbRestoreDB = new System.Windows.Forms.ToolStripButton();
            this.tsbAbout = new System.Windows.Forms.ToolStripButton();
            this.今日督办toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.新增事务ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.事务管理ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.查询打印toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.牵头人toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.退出程序ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.备份ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.还原toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMain.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSystem,
            this.帮助ToolStripMenuItem});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(1008, 28);
            this.mnuMain.TabIndex = 0;
            this.mnuMain.Text = "menuStrip1";
            this.mnuMain.ItemAdded += new System.Windows.Forms.ToolStripItemEventHandler(this.mnuMain_ItemAdded);
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
            this.tsmSystem.Size = new System.Drawing.Size(67, 24);
            this.tsmSystem.Text = "系统(&S)";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(219, 6);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(219, 6);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(219, 6);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.备份ToolStripMenuItem,
            this.还原toolStripMenuItem1,
            this.toolStripSeparator4,
            this.关于ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.帮助ToolStripMenuItem.Text = "帮助(&H)";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(212, 6);
            // 
            // sfdBackup
            // 
            this.sfdBackup.Filter = "MatterManager数据库备份文件(*.backup)|*.backup";
            // 
            // ofdRestore
            // 
            this.ofdRestore.Filter = "MatterManager备份文件(*.backup)|*.backup";
            this.ofdRestore.Title = "还原数据库文件";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbToday,
            this.toolStripSeparator5,
            this.tsbAddNew,
            this.tsbManager,
            this.tsbQueryAndPrint,
            this.toolStripSeparator6,
            this.tsbLeadmen,
            this.toolStripSeparator7,
            this.tsbBackupDB,
            this.tsbRestoreDB,
            this.toolStripSeparator8,
            this.tsbAbout});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1008, 39);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 39);
            // 
            // tsbToday
            // 
            this.tsbToday.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbToday.Image = global::MatterManager.Properties.Resources.time_small;
            this.tsbToday.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbToday.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbToday.Name = "tsbToday";
            this.tsbToday.Size = new System.Drawing.Size(36, 36);
            this.tsbToday.Text = "今日督办";
            this.tsbToday.Click += new System.EventHandler(this.tsbToday_Click);
            // 
            // tsbAddNew
            // 
            this.tsbAddNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAddNew.Image = global::MatterManager.Properties.Resources.addnew_small;
            this.tsbAddNew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbAddNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddNew.Name = "tsbAddNew";
            this.tsbAddNew.Size = new System.Drawing.Size(36, 36);
            this.tsbAddNew.Text = "新增";
            this.tsbAddNew.Click += new System.EventHandler(this.tsbAddNew_Click);
            // 
            // tsbManager
            // 
            this.tsbManager.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbManager.Image = global::MatterManager.Properties.Resources.manager_small;
            this.tsbManager.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbManager.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbManager.Name = "tsbManager";
            this.tsbManager.Size = new System.Drawing.Size(36, 36);
            this.tsbManager.Text = "管理";
            this.tsbManager.Click += new System.EventHandler(this.tsbManager_Click);
            // 
            // tsbQueryAndPrint
            // 
            this.tsbQueryAndPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbQueryAndPrint.Image = global::MatterManager.Properties.Resources.query_print_small;
            this.tsbQueryAndPrint.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbQueryAndPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbQueryAndPrint.Name = "tsbQueryAndPrint";
            this.tsbQueryAndPrint.Size = new System.Drawing.Size(36, 36);
            this.tsbQueryAndPrint.Text = "查询/打印";
            this.tsbQueryAndPrint.Click += new System.EventHandler(this.tsbQueryAndPrint_Click);
            // 
            // tsbLeadmen
            // 
            this.tsbLeadmen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbLeadmen.Image = global::MatterManager.Properties.Resources.leadmen_small;
            this.tsbLeadmen.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbLeadmen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLeadmen.Name = "tsbLeadmen";
            this.tsbLeadmen.Size = new System.Drawing.Size(36, 36);
            this.tsbLeadmen.Text = "牵头人";
            this.tsbLeadmen.Click += new System.EventHandler(this.tsbLeadmen_Click);
            // 
            // tsbBackupDB
            // 
            this.tsbBackupDB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBackupDB.Image = global::MatterManager.Properties.Resources.dbsave_small;
            this.tsbBackupDB.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbBackupDB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBackupDB.Name = "tsbBackupDB";
            this.tsbBackupDB.Size = new System.Drawing.Size(36, 36);
            this.tsbBackupDB.Text = "数据备份";
            this.tsbBackupDB.Click += new System.EventHandler(this.tsbBackupDB_Click);
            // 
            // tsbRestoreDB
            // 
            this.tsbRestoreDB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRestoreDB.Image = global::MatterManager.Properties.Resources.dbrestore_small;
            this.tsbRestoreDB.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbRestoreDB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRestoreDB.Name = "tsbRestoreDB";
            this.tsbRestoreDB.Size = new System.Drawing.Size(36, 36);
            this.tsbRestoreDB.Text = "数据还原";
            this.tsbRestoreDB.Click += new System.EventHandler(this.tsbRestoreDB_Click);
            // 
            // tsbAbout
            // 
            this.tsbAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAbout.Image = global::MatterManager.Properties.Resources.about_small;
            this.tsbAbout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAbout.Name = "tsbAbout";
            this.tsbAbout.Size = new System.Drawing.Size(36, 36);
            this.tsbAbout.Text = "关于";
            this.tsbAbout.Click += new System.EventHandler(this.tsbAbout_Click);
            // 
            // 今日督办toolStripMenuItem1
            // 
            this.今日督办toolStripMenuItem1.Image = global::MatterManager.Properties.Resources.time_small;
            this.今日督办toolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.今日督办toolStripMenuItem1.Name = "今日督办toolStripMenuItem1";
            this.今日督办toolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.今日督办toolStripMenuItem1.Size = new System.Drawing.Size(222, 38);
            this.今日督办toolStripMenuItem1.Text = "今日督办...";
            this.今日督办toolStripMenuItem1.Click += new System.EventHandler(this.今日督办toolStripMenuItem1_Click);
            // 
            // 新增事务ToolStripMenuItem
            // 
            this.新增事务ToolStripMenuItem.Image = global::MatterManager.Properties.Resources.addnew_small;
            this.新增事务ToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.新增事务ToolStripMenuItem.Name = "新增事务ToolStripMenuItem";
            this.新增事务ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.新增事务ToolStripMenuItem.Size = new System.Drawing.Size(222, 38);
            this.新增事务ToolStripMenuItem.Text = "新增事务...";
            this.新增事务ToolStripMenuItem.Click += new System.EventHandler(this.新增事务ToolStripMenuItem_Click);
            // 
            // 事务管理ToolStripMenuItem1
            // 
            this.事务管理ToolStripMenuItem1.Image = global::MatterManager.Properties.Resources.manager_small;
            this.事务管理ToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.事务管理ToolStripMenuItem1.Name = "事务管理ToolStripMenuItem1";
            this.事务管理ToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.事务管理ToolStripMenuItem1.Size = new System.Drawing.Size(222, 38);
            this.事务管理ToolStripMenuItem1.Text = "事务管理...";
            this.事务管理ToolStripMenuItem1.Click += new System.EventHandler(this.事务管理ToolStripMenuItem1_Click);
            // 
            // 查询打印toolStripMenuItem1
            // 
            this.查询打印toolStripMenuItem1.Image = global::MatterManager.Properties.Resources.query_print_small;
            this.查询打印toolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.查询打印toolStripMenuItem1.Name = "查询打印toolStripMenuItem1";
            this.查询打印toolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.查询打印toolStripMenuItem1.Size = new System.Drawing.Size(222, 38);
            this.查询打印toolStripMenuItem1.Text = "查询/打印...";
            this.查询打印toolStripMenuItem1.Click += new System.EventHandler(this.查询打印toolStripMenuItem1_Click);
            // 
            // 牵头人toolStripMenuItem1
            // 
            this.牵头人toolStripMenuItem1.Image = global::MatterManager.Properties.Resources.leadmen_small;
            this.牵头人toolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.牵头人toolStripMenuItem1.Name = "牵头人toolStripMenuItem1";
            this.牵头人toolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.牵头人toolStripMenuItem1.Size = new System.Drawing.Size(222, 38);
            this.牵头人toolStripMenuItem1.Text = "牵头人管理...";
            this.牵头人toolStripMenuItem1.Click += new System.EventHandler(this.牵头人toolStripMenuItem1_Click);
            // 
            // 退出程序ToolStripMenuItem
            // 
            this.退出程序ToolStripMenuItem.Image = global::MatterManager.Properties.Resources.exit_small;
            this.退出程序ToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.退出程序ToolStripMenuItem.Name = "退出程序ToolStripMenuItem";
            this.退出程序ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.退出程序ToolStripMenuItem.Size = new System.Drawing.Size(222, 38);
            this.退出程序ToolStripMenuItem.Text = "退出程序";
            this.退出程序ToolStripMenuItem.Click += new System.EventHandler(this.退出程序ToolStripMenuItem_Click);
            // 
            // 备份ToolStripMenuItem
            // 
            this.备份ToolStripMenuItem.Image = global::MatterManager.Properties.Resources.dbsave_small;
            this.备份ToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.备份ToolStripMenuItem.Name = "备份ToolStripMenuItem";
            this.备份ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.备份ToolStripMenuItem.Size = new System.Drawing.Size(215, 38);
            this.备份ToolStripMenuItem.Text = "备份数据库";
            this.备份ToolStripMenuItem.Click += new System.EventHandler(this.备份ToolStripMenuItem_Click);
            // 
            // 还原toolStripMenuItem1
            // 
            this.还原toolStripMenuItem1.Image = global::MatterManager.Properties.Resources.dbrestore_small;
            this.还原toolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.还原toolStripMenuItem1.Name = "还原toolStripMenuItem1";
            this.还原toolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.还原toolStripMenuItem1.Size = new System.Drawing.Size(215, 38);
            this.还原toolStripMenuItem1.Text = "还原数据库";
            this.还原toolStripMenuItem1.Click += new System.EventHandler(this.还原toolStripMenuItem1_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Image = global::MatterManager.Properties.Resources.about_small;
            this.关于ToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(215, 38);
            this.关于ToolStripMenuItem.Text = "关于(&A)...";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.mnuMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuMain;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MatterManager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem 备份ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 还原toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.SaveFileDialog sfdBackup;
        private System.Windows.Forms.OpenFileDialog ofdRestore;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbToday;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tsbAddNew;
        private System.Windows.Forms.ToolStripButton tsbManager;
        private System.Windows.Forms.ToolStripButton tsbQueryAndPrint;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton tsbLeadmen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton tsbBackupDB;
        private System.Windows.Forms.ToolStripButton tsbRestoreDB;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton tsbAbout;
    }
}

