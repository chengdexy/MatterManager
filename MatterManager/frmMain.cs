using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MatterManagerClasses;
using System.IO;
using DatabaseHelpers;

namespace MatterManager
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void 退出程序ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 牵头人toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (checkFormExist("frmLeadmanManager"))
            {
                Application.OpenForms["frmLeadmanManager"].Focus();
            }
            else
            {
                frmLeadmanManager f = new MatterManager.frmLeadmanManager();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void 新增事务ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkFormExist("frmAddMatterFile"))
            {
                Application.OpenForms["frmAddMatterFile"].Focus();
            }
            else
            {
                frmAddMatterFile f = new MatterManager.frmAddMatterFile();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void 事务管理ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (checkFormExist("frmMatterManager"))
            {
                Application.OpenForms["frmMatterManager"].Focus();
            }
            else
            {
                frmMatterManager f = new frmMatterManager();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmTodayToDo f = new frmTodayToDo();
            f.MdiParent = this;
            f.Show();
        }

        private void 今日督办toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (checkFormExist("frmTodayToDo"))
            {
                Application.OpenForms["frmTodayToDo"].Focus();
            }
            else
            {
                frmTodayToDo f = new frmTodayToDo();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void 查询打印toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (checkFormExist("frmQueryMatters"))
            {
                Application.OpenForms["frmQueryMatters"].Focus();
            }
            else
            {
                frmQueryMatters f = new frmQueryMatters();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout f = new MatterManager.frmAbout();
            f.ShowDialog(this);
        }

        private void 备份ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sfdBackup.ShowDialog();
            if (!string.IsNullOrEmpty(sfdBackup.FileName))
            {
                string targetPath = sfdBackup.FileName;
                OleDbHelper.backupDatabase(targetPath);
                MessageBox.Show("数据库文件已备份至(" + sfdBackup.FileName + ").", "备份完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void 还原toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ofdRestore.ShowDialog();
            if (!string.IsNullOrEmpty(ofdRestore.FileName))
            {
                string sourcePath = ofdRestore.FileName;
                OleDbHelper.restoreDatabase(sourcePath);
                MessageBox.Show("数据库文件已还原,请重启程序.(点击确定后将关闭当前程序进程)", "还原完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void mnuMain_ItemAdded(object sender, ToolStripItemEventArgs e)
        {
            if (e.Item.Text.Length == 0)
            {
                e.Item.Visible = false;
            }
        }

        private void tsbToday_Click(object sender, EventArgs e)
        {
            if (checkFormExist("frmTodayToDo"))
            {
                Application.OpenForms["frmTodayToDo"].Focus();
            }
            else
            {
                frmTodayToDo f = new frmTodayToDo();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void tsbAddNew_Click(object sender, EventArgs e)
        {
            if (checkFormExist("frmAddMatterFile"))
            {
                Application.OpenForms["frmAddMatterFile"].Focus();
            }
            else
            {
                frmAddMatterFile f = new MatterManager.frmAddMatterFile();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void tsbManager_Click(object sender, EventArgs e)
        {
            if (checkFormExist("frmMatterManager"))
            {
                Application.OpenForms["frmMatterManager"].Focus();
            }
            else
            {
                frmMatterManager f = new frmMatterManager();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void tsbQueryAndPrint_Click(object sender, EventArgs e)
        {
            if (checkFormExist("frmQueryMatters"))
            {
                Application.OpenForms["frmQueryMatters"].Focus();
            }
            else
            {
                frmQueryMatters f = new frmQueryMatters();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void tsbLeadmen_Click(object sender, EventArgs e)
        {
            if (checkFormExist("frmLeadmanManager"))
            {
                Application.OpenForms["frmLeadmanManager"].Focus();
            }
            else
            {
                frmLeadmanManager f = new frmLeadmanManager();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void tsbBackupDB_Click(object sender, EventArgs e)
        {
            sfdBackup.ShowDialog();
            if (!string.IsNullOrEmpty(sfdBackup.FileName))
            {
                string targetPath = sfdBackup.FileName;
                OleDbHelper.backupDatabase(targetPath);
                MessageBox.Show("数据库文件已备份至(" + sfdBackup.FileName + ").", "备份完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tsbRestoreDB_Click(object sender, EventArgs e)
        {
            ofdRestore.ShowDialog();
            if (!string.IsNullOrEmpty(ofdRestore.FileName))
            {
                string sourcePath = ofdRestore.FileName;
                OleDbHelper.restoreDatabase(sourcePath);
                MessageBox.Show("数据库文件已还原,请重启程序.(点击确定后将关闭当前程序进程)", "还原完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void tsbAbout_Click(object sender, EventArgs e)
        {
            frmAbout f = new frmAbout();
            f.ShowDialog(this);

        }
        /// <summary>
        /// 判断子窗体是否已经打开过
        /// </summary>
        /// <param name="formName">子窗体Name属性值</param>
        /// <returns>true:已打开,false:未打卡</returns>
        private bool checkFormExist(string formName)
        {
            if (Application.OpenForms[formName] == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
