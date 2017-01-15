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
    public partial class frmMatterManager : Form
    {
        public frmMatterManager()
        {
            InitializeComponent();
        }

        private void frmMatterManager_Load(object sender, EventArgs e)
        {
            //初始化
            refreshMatterList();

        }
        /// <summary>
        /// 刷新dgvMatterList
        /// </summary>
        private void refreshMatterList()
        {
            dgvMatterList.Rows.Clear();
            List<matterFiles> mfList = MatterHelper.getAllMatters();
            for (int i = 0; i < mfList.Count; i++)
            {
                matterFiles mf = mfList[i];
                int id = mf.Id;
                string title = mf.Title;
                string begin = mf.BeginDate.ToShortDateString();
                string state = mf.State.ToString();
                dgvMatterList.Rows.Clear();
                dgvMatterList.Rows.Add(i + 1, title, begin, state, id);
            }
        }
    }
}
