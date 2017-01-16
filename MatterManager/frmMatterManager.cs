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
                string content = tiList[i].Content;
                string state = tiList[i].State.ToString();

                dgvTodoList.Rows.Add(i + 1, content, state, mfNum);
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
                string connect = srList[i].ConnectDate.ToShortDateString();
                string result = srList[i].Result;

                dgvHistoryList.Rows.Add(i + 1, connect, result, mfNum);
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
            matterFiles mf = mfList[dgvMatterList.Rows[0].Index];
            if (MessageBox.Show("确定要删除这件督办事务吗?操作不可逆.", "删除确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show(MatterHelper.DeleteMatter(mf), "结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refreshMatterList();
            }
        }
    }
}
