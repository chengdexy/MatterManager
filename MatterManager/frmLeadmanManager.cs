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
    public partial class frmLeadmanManager : Form
    {
        public frmLeadmanManager()
        {
            InitializeComponent();
        }

        private void frmLeadmanManager_Load(object sender, EventArgs e)
        {
            //初始化
            refreshDGV();
        }
        /// <summary>
        /// 刷新dgvLeadmanList
        /// </summary>
        private void refreshDGV()
        {
            List<Leadman> leadmanList = MatterHelper.getAllLeadmans();
            dgvLeadmanList.Rows.Clear();
            for (int i = 0; i < leadmanList.Count; i++)
            {
                dgvLeadmanList.Rows.Add(i + 1, leadmanList[i].Name, leadmanList[i].ItsPost);
            }
            //dgvLeadmanList.Refresh();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            string leadName = "";
            string leadPost = "";
            if (!string.IsNullOrEmpty(txtName.Text))
            {
                leadName = txtName.Text;
            }
            else
            {
                MessageBox.Show("请输入牵头人姓名!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtName.Focus();
                return;
            }
            if (!string.IsNullOrEmpty(txtPost.Text))
            {
                leadPost = txtPost.Text;
            }
            else
            {
                MessageBox.Show("请输入牵头人职务!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPost.Focus();
                return;
            }
            Leadman l = new Leadman(leadName, leadPost);
            MatterHelper.SaveLeadman(l);
            refreshDGV();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void frmLeadmanManager_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string name = dgvLeadmanList.SelectedRows[0].Cells[1].Value.ToString();
            string post = dgvLeadmanList.SelectedRows[0].Cells[2].Value.ToString();
            Leadman l = new Leadman(name, post);
            MatterHelper.DeleteLeadman(l);
            refreshDGV();
        }
    }
}
