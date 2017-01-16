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
    public partial class frmAddNewTodoItem : Form
    {
        private int? mfId = null;
        TodoItem ti = null;

        public frmAddNewTodoItem(int mfNum)
        {
            mfId = mfNum;
            InitializeComponent();
        }

        public frmAddNewTodoItem(object ti, int mfNum)
        {
            mfId = mfNum;
            ti = (TodoItem)ti;
            InitializeComponent();
        }

        private void frmAddNewTodoItem_Load(object sender, EventArgs e)
        {
            if (ti != null)
            {

            }
        }

        private void rbDoing_Click(object sender, EventArgs e)
        {
            if (rbDoing.Checked == true)
            {
                dtpDone.Enabled = false;
                txtDoneDescription.Enabled = false;
                dtpStop.Enabled = false;
                txtStopReason.Enabled = false;
            }
        }

        private void rbDone_Click(object sender, EventArgs e)
        {
            if (rbDone.Checked == true)
            {
                dtpDone.Enabled = true;
                txtDoneDescription.Enabled = true;
                dtpStop.Enabled = false;
                txtStopReason.Enabled = false;
            }
        }

        private void rbStop_Click(object sender, EventArgs e)
        {
            if (rbStop.Checked == true)
            {
                dtpDone.Enabled = false;
                txtDoneDescription.Enabled = false;
                dtpStop.Enabled = true;
                txtStopReason.Enabled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddNewTodoItem_FormClosing(object sender, FormClosingEventArgs e)
        {

            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtContent.Text))
            {
                string content = txtContent.Text.Trim();
            }
            else
            {
                MessageBox.Show("请输入待办事项内容!");
                txtContent.Focus();
                return;
            }
            if (rbDoing.Checked)
            {
                //选中doing
            }
            else if (rbDone.Checked)
            {
                //选中done
            }
            else if (rbStop.Checked)
            {
                //选中stop
            }
            else
            {
                //全都没选中
            }

        }
    }
}
