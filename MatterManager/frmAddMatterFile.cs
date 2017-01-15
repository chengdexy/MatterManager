using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MatterManagerClasses;
using MatterHelpers;
using System.IO;

namespace MatterManager
{
    public partial class frmAddMatterFile : Form
    {
        public frmAddMatterFile()
        {
            InitializeComponent();
        }

        private void frmAddMatterFile_Load(object sender, EventArgs e)
        {
            //初始化窗体内容
            //date time picker时间显示当前时间
            dtpBeginDate.Value = DateTime.Now;
            //清除data grid view控件中的空行
            dgvTodoItemList.RowCount = 0;
            //获取所有已存在的Leadman信息,附加在combo box的items集合中
            List<Leadman> leaderList = MatterHelper.getAllLeadmans();
            if (leaderList.Count != 0)
            {
                for (int i = 0; i < leaderList.Count; i++)
                {
                    cboLeadman.Items.Add(leaderList[i].Name + ":" + leaderList[i].ItsPost);
                }
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnCancelAndClear_Click(object sender, EventArgs e)
        {
            txtNewItemContent.Text = "";
        }

        private void btnUploadFile_Click(object sender, EventArgs e)
        {
            ofdUploadFile.FileName = "";
            ofdUploadFile.Filter = "Word 2003 (*.doc)|*.doc|Word 2007 (*.docx)|*.docx";
            ofdUploadFile.ShowDialog();
            if (!String.IsNullOrEmpty(ofdUploadFile.FileName))
            {
                lblPathOfUploaded.Text = ofdUploadFile.FileName;
            }
        }

        private void btnAddToList_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtNewItemContent.Text))
            {
                int rowNumber = dgvTodoItemList.RowCount + 1;
                string rowContent = txtNewItemContent.Text;
                dgvTodoItemList.Rows.Add(rowNumber.ToString(), rowContent);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dgvTodoItemList.Rows.Remove(dgvTodoItemList.SelectedRows[0]);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void ClearAll()
        {
            //清空所有内容
            txtTitle.Text = "";
            txtDescription.Text = "";
            txtFileNumber.Text = "";
            txtNewItemContent.Text = "";
            dtpBeginDate.Value = DateTime.Now;
            ofdUploadFile.FileName = "";
            lblPathOfUploaded.Text = "请点击右侧按钮上传文件电子版";
            dgvTodoItemList.Rows.Clear();
        }

        private bool SaveAll()
        {
            //收集用户数据
            matterFiles mf = new matterFiles();
            //公文标题
            if (!String.IsNullOrEmpty(txtTitle.Text))
            {
                mf.Title = txtTitle.Text;
            }
            else
            {
                MessageBox.Show("请输入公文标题!");
                txtTitle.Focus();
                return false;
            }
            //公文文号
            if (!String.IsNullOrEmpty(txtFileNumber.Text))
            {
                mf.FileNum = txtFileNumber.Text;
            }
            else
            {
                MessageBox.Show("请输入公文文号!");
                txtFileNumber.Focus();
                return false;
            }
            //提醒间隔
            if (!String.IsNullOrEmpty(txtRemind.Text))
            {
                mf.HowManyHoursToRemind = Convert.ToInt32(txtRemind.Text) * 24;
            }
            else
            {
                MessageBox.Show("请输入督办频率!");
                txtRemind.Focus();
                return false;
            }
            //开始日期
            mf.BeginDate = dtpBeginDate.Value;
            //牵头人
            string leaderName = cboLeadman.Text.Split(':')[0].Trim();
            string leaderPost = cboLeadman.Text.Split(':')[1].Trim();
            mf.Leader = new Leadman(leaderName, leaderPost);
            //事务描述(备注)
            mf.Describe = txtDescription.Text;
            //文件上传路径
            string uploadPath = ofdUploadFile.FileName;
            //待办事项清单
            for (int i = 0; i < dgvTodoItemList.RowCount; i++)
            {
                mf.TodoItemList.Add(new TodoItem(dgvTodoItemList.Rows[i].Cells[1].Value.ToString()));
            }
            //将文件保存
            if (!String.IsNullOrEmpty(uploadPath))
            {
                string targetPath = Path.Combine(Environment.CurrentDirectory, Path.GetFileName(uploadPath));
                mf.uploadFile(uploadPath, targetPath);
            }
            else
            {
                mf.FileAddr = "";
            }
            //调用MatterHelper的SaveMatterToDatabase方法
            MatterHelper.InsertMatter(mf);
            return true;
        }

        //保存并退出按钮
        private void btnSaveAndExit_Click(object sender, EventArgs e)
        {
            if (SaveAll())
            {
                this.Close();
                this.Dispose();
            }
        }

        private void btnJustSave_Click(object sender, EventArgs e)
        {
            if (SaveAll())
            {
                ClearAll();
            }
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            txtFileTitle.Text = txtTitle.Text;
        }

        private void frmAddMatterFile_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
