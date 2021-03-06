﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MatterManagerClasses;
using MatterHelpers;
using System.IO;

namespace MatterManager
{
    public partial class frmAddMatterFile : Form
    {
        private bool isEditMode = false;
        private matterFiles editMF;
        private List<Leadman> leaderList;

        public frmAddMatterFile()
        {
            InitializeComponent();
        }

        public frmAddMatterFile(object mf)
        {
            isEditMode = true;
            editMF = (matterFiles)mf;
            InitializeComponent();
        }

        private void frmAddMatterFile_Load(object sender, EventArgs e)
        {
            //初始化窗体内容

            //获取所有已存在的Leadman信息,附加在combo box的items集合中
            leaderList = MatterHelper.getAllLeadmans();
            cboLeadman.DataSource = leaderList;
            cboLeadman.DisplayMember = "Name";
            cboLeadman.ValueMember = "Id";
            cboLeadman.Text = "";

            if (isEditMode)
            {
                //编辑模式
                this.Text = "编辑督办事务";
                txtTitle.Text = editMF.Title;
                dtpBeginDate.Value = editMF.BeginDate;
                txtDescription.Text = editMF.Describe;
                txtRemind.Text = (editMF.HowManyHoursToRemind / 24).ToString();
                txtFileTitle.Text = txtTitle.Text;
                txtFileNumber.Text = editMF.FileNum;
                ofdUploadFile.FileName = editMF.FileAddr;
                lblPathOfUploaded.Text = editMF.FileAddr;
                cboLeadman.Text = editMF.Leader.Name;
                txtLeaderPost.Text = editMF.Leader.ItsPost;
                List<TodoItem> list = editMF.TodoItemList;
                for (int i = 0; i < list.Count; i++)
                {
                    dgvTodoItemList.Rows.Add(i + 1, list[i].Content);
                }
                btnAddToList.Enabled = false;
                btnDelete.Enabled = false;
                if (!string.IsNullOrEmpty(lblPathOfUploaded.Text))
                {
                    btnOpenFile.Visible = true;
                }
            }
            else
            {
                //新建模式
                //date time picker时间显示当前时间
                dtpBeginDate.Value = DateTime.Today;
                //清除data grid view控件中的空行
                dgvTodoItemList.Rows.Clear();
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
                txtNewItemContent.Text = "";
                txtNewItemContent.Focus();
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
            dtpBeginDate.Value = DateTime.Today;
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
                MessageBox.Show("请输入公文标题!","提示",MessageBoxButtons.OK,MessageBoxIcon.Information );
                txtTitle.Focus();
                return false;
            }
            //公文文号
            mf.FileNum = txtFileNumber.Text;
            //提醒间隔
            if (!String.IsNullOrEmpty(txtRemind.Text))
            {
                mf.HowManyHoursToRemind = Convert.ToInt32(txtRemind.Text) * 24;
            }
            else
            {
                MessageBox.Show("请输入督办频率!","提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtRemind.Focus();
                return false;
            }
            //开始日期
            mf.BeginDate = dtpBeginDate.Value;
            //牵头人

            if (!string.IsNullOrEmpty(cboLeadman.Text))
            {

                string leaderName = cboLeadman.Text.Trim();
                string leaderPost = txtLeaderPost.Text.Trim();
                mf.Leader = new Leadman(leaderName, leaderPost);

            }
            else
            {
                MessageBox.Show("请选择或输入牵头人信息!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboLeadman.Focus();
                return false;
            }
            //事务描述(备注)
            mf.Describe = txtDescription.Text;
            //文件上传路径
            string uploadPath = ofdUploadFile.FileName;
            //待办事项清单
            if (dgvTodoItemList.RowCount != 0)
            {
                for (int i = 0; i < dgvTodoItemList.RowCount; i++)
                {
                    mf.TodoItemList.Add(new TodoItem(dgvTodoItemList.Rows[i].Cells[1].Value.ToString()));
                }
            }
            else
            {
                MessageBox.Show("督办事务中应至少包含一条待办事项!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNewItemContent.Focus();
                return false;
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
            if (isEditMode)
            {
                //编辑模式使用update
                MatterHelper.UpdateMatter(mf);
            }
            else
            {
                //新增模式使用Insert,向数据库中新增一组Matter
                MatterHelper.InsertMatter(mf);
            }
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

        private void cboLeadman_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cboLeadman.SelectedValue is Int32)
            {
                txtLeaderPost.Text = "";
                foreach (Leadman leader in leaderList)
                {
                    if (leader.Id == Convert.ToInt32(cboLeadman.SelectedValue))
                    {
                        txtLeaderPost.Text = leader.ItsPost;
                        break;
                    }
                }
            }
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            if (File.Exists(lblPathOfUploaded.Text))
            {
                System.Diagnostics.Process.Start(lblPathOfUploaded.Text);
            } 
        }
    }
}
