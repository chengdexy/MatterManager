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

        private void 来自公文ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddMatterFile f = new frmAddMatterFile();
            f.MdiParent = this;
            f.Show();
        }

        private void 退出程序ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
