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
            Environment.Exit(0);
        }

        private void 牵头人toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmLeadmanManager f = new MatterManager.frmLeadmanManager();
            f.MdiParent = this;
            f.Show();
        }

        private void 新增事务ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddMatterFile f = new MatterManager.frmAddMatterFile();
            f.MdiParent = this;
            f.Show();
        }

        private void 事务管理ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmMatterManager f = new frmMatterManager();
            f.MdiParent = this;
            f.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmTodayToDo f = new frmTodayToDo();
            f.MdiParent = this;
            f.Show();
        }

        private void 今日督办toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmTodayToDo f = new frmTodayToDo();
            f.MdiParent = this;
            f.Show();
        }
    }
}
