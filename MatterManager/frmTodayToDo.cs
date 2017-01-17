using MatterHelpers;
using MatterManagerClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatterManager
{
    public partial class frmTodayToDo : Form
    {
        public frmTodayToDo()
        {
            InitializeComponent();
        }

        private void frmTodayToDo_Load(object sender, EventArgs e)
        {
            refreshTodayList();
        }

        public void refreshTodayList()
        {
            dgvNeedAlertMatters.Rows.Clear();
            List<matterFiles> mfList = MatterHelper.getAllNeedAlertMatters();
            for (int i = 0; i < mfList.Count; i++)
            {
                int id = mfList[i].Id;
                string begin = mfList[i].BeginDate.ToString("yyyy年MM月dd日");
                string title = mfList[i].Title;
                string leader = mfList[i].Leader.Name;
                dgvNeedAlertMatters.Rows.Add(i + 1, title, begin, leader, id);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvNeedAlertMatters.SelectedRows.Count != 0)
            {
                int idShow = Convert.ToInt32(dgvNeedAlertMatters.SelectedRows[0].Cells["mfNum"].Value);
                frmMatterManager f = new MatterManager.frmMatterManager(idShow);
                f.MdiParent = this.MdiParent;
                f.Show();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refreshTodayList();
        }
    }
}
