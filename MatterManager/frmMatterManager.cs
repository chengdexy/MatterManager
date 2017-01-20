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
        private static List<matterFiles> mfList = new List<matterFiles>();
        private static int mfIdToShow = -1;

        public frmMatterManager()
        {
            InitializeComponent();
        }

        public frmMatterManager(int mfNum)
        {
            mfIdToShow = mfNum;
            InitializeComponent();
        }

        private void frmMatterManager_Load(object sender, EventArgs e)
        {
            //初始化
            refreshMatterList();
            if (mfIdToShow != -1)
            {
                for (int i = 0; i < dgvMatterList.Rows.Count; i++)
                {
                    if (Convert.ToInt32(dgvMatterList.Rows[i].Cells["mId"].Value) == mfIdToShow)
                    {
                        dgvMatterList.Rows[i].Selected = true;
                        refreshTodoList(i);
                        refreshHistoryList(i);
                        break;
                    }
                }
            }

        }
        /// <summary>
        /// 刷新dgvMatterList
        /// </summary>
        private void refreshMatterList()
        {
            dgvMatterList.Rows.Clear();
            dgvTodoList.Rows.Clear();
            dgvHistoryList.Rows.Clear();
            mfList = MatterHelper.getAllMatters();
            for (int i = 0; i < mfList.Count; i++)
            {
                matterFiles mf = mfList[i];
                int id = mf.Id;
                string title = mf.Title;
                string begin = mf.BeginDate.ToString("yyyy年MM月dd日");
                string state = mf.State.ToString();
                dgvMatterList.Rows.Add(i + 1, title, begin, state, id);
            }
            if (dgvMatterList.Rows.Count != 0)
            {
                refreshTodoList(0);
                refreshHistoryList(0);
            }
        }

        private void dgvMatterList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                refreshTodoList(e.RowIndex);
                refreshHistoryList(e.RowIndex);
            }
        }

        /// <summary>
        /// 刷新dgvTodoList
        /// </summary>
        /// <param name="rowNum">dgvMatterList选中行行号(从0开始)</param>
        private void refreshTodoList(int rowNum)
        {
            dgvTodoList.Rows.Clear();
            List<TodoItem> tiList = mfList[rowNum].TodoItemList;
            int mfNum = mfList[rowNum].Id;
            for (int i = 0; i < tiList.Count; i++)
            {
                int id = tiList[i].Id;
                string content = tiList[i].Content;
                string state = tiList[i].State.ToString();

                dgvTodoList.Rows.Add(i + 1, content, state, mfNum, id);
            }
        }
        /// <summary>
        /// 刷新dgvHistoryList
        /// </summary>
        /// <param name="rowNum">dgvMatterList选中行行号(从0开始)</param>
        private void refreshHistoryList(int rowNum)
        {
            dgvHistoryList.Rows.Clear();
            List<SuperviseRecord> srList = mfList[rowNum].HistoryRecord;
            int mfNum = mfList[rowNum].Id;
            for (int i = 0; i < srList.Count; i++)
            {
                string id = srList[i].Id.ToString();
                string connect = srList[i].ConnectDate.ToString("yyyy年MM月dd日");
                string result = srList[i].Result;

                dgvHistoryList.Rows.Add(i + 1, connect, result, mfNum, id);
            }
        }

        private void btnNewMatter_Click(object sender, EventArgs e)
        {
            frmAddMatterFile f = new frmAddMatterFile();
            f.ShowDialog();
            refreshMatterList();
        }

        private void btnDelMatter_Click(object sender, EventArgs e)
        {
            if (dgvMatterList.Rows.Count != 0)
            {
                matterFiles mf = mfList[dgvMatterList.Rows[0].Index];
                if (MessageBox.Show("确定要删除这件督办事务吗?操作不可逆.", "删除确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    MessageBox.Show(MatterHelper.DeleteMatter(mf), "结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refreshMatterList();
                }
            }
        }

        private void btnEditMatter_Click(object sender, EventArgs e)
        {
            if (dgvMatterList.SelectedRows.Count != 0)
            {
                int rowNum = dgvMatterList.SelectedRows[0].Index;
                matterFiles mf = mfList[rowNum];
                frmAddMatterFile frm = new MatterManager.frmAddMatterFile(mf);
                frm.ShowDialog();
            }
        }

        private void btnNewTodo_Click(object sender, EventArgs e)
        {
            if (dgvMatterList.SelectedRows.Count != 0)
            {
                int mfNum = Convert.ToInt32(dgvTodoList.SelectedRows[0].Cells["mfNum"].Value);
                frmAddNewTodoItem f = new frmAddNewTodoItem(mfNum);
                f.Text = "新增待办事项";
                f.ShowDialog(this);
                refreshMatterList();
            }
        }

        private void btnEditTodo_Click(object sender, EventArgs e)
        {
            if (dgvTodoList.SelectedRows.Count != 0)
            {
                int todoId = Convert.ToInt32(dgvTodoList.SelectedRows[0].Cells["todoId"].Value);
                int mfRowNum = dgvMatterList.SelectedRows[0].Index;
                matterFiles mf = mfList[mfRowNum];
                TodoItem ti = mf.TodoItemList[dgvTodoList.SelectedRows[0].Index];
                frmAddNewTodoItem f = new frmAddNewTodoItem(ti, todoId);
                f.Text = "编辑待办事项";
                f.ShowDialog(this);
                refreshMatterList();
            }
        }

        private void btnDeleteTodo_Click(object sender, EventArgs e)
        {
            if (dgvTodoList.Rows.Count > 1)
            {
                if (dgvTodoList.SelectedRows.Count != 0)
                {
                    int todoid = Convert.ToInt32(dgvTodoList.SelectedRows[0].Cells["todoId"].Value);
                    if (dgvTodoList.SelectedRows[0].Cells[2].Value.ToString() != MyStates.办理中.ToString())
                    {
                        MatterHelper.DeleteTodoItem(todoid);
                    }
                    else
                    {
                        MessageBox.Show("你不能删除一个还未办结或中止的待办事项!");
                    }
                }
            }
            else if (dgvTodoList.Rows.Count == 1)
            {
                MessageBox.Show("删除失败,事务需要至少包含一条待办事项.");
            }
            else
            {
                return;
            }
        }

        private void btnAddHistory_Click(object sender, EventArgs e)
        {
            if (dgvMatterList.SelectedRows.Count != 0)
            {
                int mfNum = Convert.ToInt32(dgvMatterList.SelectedRows[0].Cells["mId"].Value);
                frmAddNewHistory f = new frmAddNewHistory(mfNum);
                f.Text = "新增督办反馈记录";
                f.ShowDialog(this);
                refreshMatterList();
            }
        }

        private void btnEditHistory_Click(object sender, EventArgs e)
        {
            if (dgvHistoryList.SelectedRows.Count != 0)
            {
                int hId = Convert.ToInt32(dgvHistoryList.SelectedRows[0].Cells["hId"].Value);
                matterFiles mf = mfList[dgvMatterList.SelectedRows[0].Index];
                SuperviseRecord sr = mf.HistoryRecord[dgvHistoryList.SelectedRows[0].Index];
                frmAddNewHistory f = new frmAddNewHistory(sr, hId);
                f.Text = "编辑督办反馈记录";
                f.ShowDialog(this);
                refreshMatterList();
            }
        }
    }
}
