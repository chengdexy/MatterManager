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
    public partial class frmAddNewHistory : Form
    {
        private static bool isEditMode = false;
        private static int myHisId;
        private static int mfId;
        private static SuperviseRecord myHistory;
        /// <summary>
        /// 新增模式构造
        /// </summary>
        public frmAddNewHistory(int mfNum)
        {
            mfId = mfNum;
            InitializeComponent();
        }
        /// <summary>
        /// 编辑模式构造
        /// </summary>
        /// <param name="hId"></param>
        public frmAddNewHistory(object sl, int hId)
        {
            myHistory = (SuperviseRecord)sl;
            isEditMode = true;
            myHisId = hId;
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddNewHistory_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        private void frmAddNewHistory_Load(object sender, EventArgs e)
        {
            if (isEditMode)
            {
                dtpConnect.Value = myHistory.ConnectDate;
                txtResult.Text = myHistory.Result;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isEditMode)
            {
                //编辑模式
                SuperviseRecord sr = new SuperviseRecord(dtpConnect.Value, txtResult.Text);
                MatterHelper.UpdateSuperviseRecord(sr, myHisId);
                this.Close();
            }
            else
            {
                //新增模式
                if (!string.IsNullOrEmpty(txtResult.Text))
                {
                    SuperviseRecord sr = new SuperviseRecord(dtpConnect.Value, txtResult.Text);
                    MatterHelper.InsertSuperviseRecord(sr, mfId);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("请输入反馈内容!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtResult.Focus();
                    return;
                }
            }
        }
    }
}
