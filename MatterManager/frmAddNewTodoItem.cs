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
    public partial class frmAddNewTodoItem : Form
    {
        private static int? mfId = null;
        private static TodoItem myti = null;
        private static bool isEditMode = false;
        private static int? tId = null;
        /// <summary>
        /// 新增模式构造
        /// </summary>
        /// <param name="mfNum">欲向其添加todoItem的Matter的id号</param>
        public frmAddNewTodoItem(int mfNum)
        {
            mfId = mfNum;
            InitializeComponent();
        }
        /// <summary>
        /// 编辑模式构造
        /// </summary>
        /// <param name="ti">目标TodoItem</param>
        /// <param name="todoId">目标数据库id</param>
        public frmAddNewTodoItem(object ti, int todoId)
        {
            tId = todoId;
            myti = (TodoItem)ti;
            isEditMode = true;
            InitializeComponent();
        }

        private void frmAddNewTodoItem_Load(object sender, EventArgs e)
        {
            if (isEditMode)
            {
                txtContent.Text = myti.Content;
                txtDoneDescription.Text = myti.DoneDescription;
                txtStopReason.Text = myti.StopReason;
                if (myti.DoneDate != null && myti.DoneDate != MatterHelper.defaultDate)
                {
                    dtpDone.Value = myti.DoneDate;
                }
                if (myti.StopDate != null && myti.StopDate != MatterHelper.defaultDate)
                {
                    dtpStop.Value = myti.StopDate;
                }
                if (myti.State == MyStates.办理中)
                {
                    label1.Enabled = false;
                    label2.Enabled = false;
                    label3.Enabled = false;
                    label4.Enabled = false;
                    rbDoing.Checked = true;
                    dtpDone.Enabled = false;
                    txtDoneDescription.Enabled = false;
                    dtpStop.Enabled = false;
                    txtStopReason.Enabled = false;
                }
                else if (myti.State == MyStates.已中止)
                {
                    label1.Enabled = false;
                    label2.Enabled = false;
                    label3.Enabled = true;
                    label4.Enabled = true;
                    rbStop.Checked = true;
                    dtpDone.Enabled = false;
                    txtDoneDescription.Enabled = false;
                    dtpStop.Enabled = true;
                    txtStopReason.Enabled = true;
                }
                else
                {
                    label1.Enabled = true;
                    label2.Enabled = true;
                    label3.Enabled = false;
                    label4.Enabled = false;
                    rbDone.Checked = true;
                    dtpDone.Enabled = true;
                    txtDoneDescription.Enabled = true;
                    dtpStop.Enabled = false;
                    txtStopReason.Enabled = false;
                }
            }
            else
            {
                rbDoing.Checked = true;
                rbDone.Enabled = false;
                rbStop.Enabled = false;
                dtpDone.Enabled = false;
                txtDoneDescription.Enabled = false;
                dtpStop.Enabled = false;
                txtStopReason.Enabled = false;
            }
        }

        private void rbDoing_Click(object sender, EventArgs e)
        {
            if (rbDoing.Checked == true)
            {
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;

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
                label1.Enabled = true;
                label2.Enabled = true;
                label3.Enabled = false;
                label4.Enabled = false;

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
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = true;
                label4.Enabled = true;

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
            string content = "";
            DateTime done = MatterHelper.defaultDate;
            string description = "";
            DateTime stop = MatterHelper.defaultDate;
            string reason = "";
            MyStates state;

            //验证合法性,并获取所需变量值
            if (!string.IsNullOrEmpty(txtContent.Text))
            {
                content = txtContent.Text.Trim();
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
                state = MyStates.办理中;
            }
            else if (rbDone.Checked)
            {
                //选中done
                if (!string.IsNullOrEmpty(txtDoneDescription.Text))
                {
                    description = txtDoneDescription.Text;
                }
                else
                {
                    MessageBox.Show("请输入办理结果!");
                    txtDoneDescription.Focus();
                    return;
                }
                state = MyStates.已办结;
                done = dtpDone.Value;
            }
            else if (rbStop.Checked)
            {
                //选中stop
                if (!string.IsNullOrEmpty(txtStopReason.Text))
                {
                    reason = txtStopReason.Text;
                }
                else
                {
                    MessageBox.Show("请输入中止原因");
                    txtStopReason.Focus();
                    return;
                }
                state = MyStates.已中止;
                stop = dtpStop.Value;
            }
            else
            {
                //全都没选中
                MessageBox.Show("请至少选中一个办理状态选项!");
                rbDoing.Focus();
                return;
            }
            //将变量值存入数据库
            TodoItem ti = new TodoItem(content);
            ti.DoneDate = done;
            ti.DoneDescription = description;
            ti.StopDate = stop;
            ti.StopReason = reason;
            ti.State = state;
            if (isEditMode)
            {
                MatterHelper.UpdateTodoItem(ti, (int)tId);
            }
            else
            {
                MatterHelper.InsertTodoItem(ti, (int)mfId);
            }
            this.Close();
        }
    }
}
