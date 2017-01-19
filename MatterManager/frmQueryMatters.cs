using DatabaseHelpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatterManager
{
    public partial class frmQueryMatters : Form
    {
        private static string sql;

        public frmQueryMatters()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmQueryMatters_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        private void frmQueryMatters_Load(object sender, EventArgs e)
        {
            InitControls();
        }

        private void InitControls()
        {
            dtpFrom.Value = DateTime.Today.AddDays(-1);
            dtpTo.Value = DateTime.Today;
            chkAllDate.Checked = false;
            txtKeyWords.Text = "";
            chkDoing.Checked = true;
            chkDone.Checked = false;
            chkStop.Checked = false;
            dgvMatters.Rows.Clear();
            dgvTodoList.Rows.Clear();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            //check date
            sql = "select beginDate,title,state,id from tbMatter where 1=1";
            if (!chkAllDate.Checked)
            {
                string dateBegin = dtpFrom.Value.ToString("#yyyy-MM-dd 00:00:00#");
                string dateStop = dtpTo.Value.ToString("#yyyy-MM-dd 23:59:59 #");
                sql += " and (beginDate>=" + dateBegin + " and beginDate<=" + dateStop + ")";
            }
            //check key
            if (!string.IsNullOrEmpty(txtKeyWords.Text))
            {
                sql += " and (title like '%" + txtKeyWords.Text.Trim() + "%')";
            }
            //check doing/done/stop
            sql += " and (1=2";
            if (chkDoing.Checked)
            {
                sql += " or state='0'";
            }
            if (chkDone.Checked)
            {
                sql += " or state='1'";
            }
            if (chkStop.Checked)
            {
                sql += " or state='2'";
            }
            sql += ")";
            refreshMatterList(sql);
        }
        /// <summary>
        /// 依据查询条件刷新事务列表
        /// </summary>
        /// <param name="sqlStr">查询条件sql语句</param>
        private void refreshMatterList(string sqlStr)
        {
            dgvMatters.Rows.Clear();
            dgvTodoList.Rows.Clear();
            OleDbDataReader dr = OleDbHelper.ExecuteReader(sqlStr);
            if (dr.HasRows)
            {
                int i = 1;
                while (dr.Read())
                {
                    string title = dr["title"].ToString();
                    string state = "";
                    switch (Convert.ToInt32(dr["state"]))
                    {
                        case 0:
                            state = "办理中";
                            break;
                        case 1:
                            state = "已办结";
                            break;
                        case 2:
                            state = "已中止";
                            break;
                        default:
                            break;
                    }
                    string id = dr["id"].ToString();
                    dgvMatters.Rows.Add(i++, title, state, id);
                }
            }
            dr.Close();
            //refreshTodoList(Convert.ToInt32(dgvMatters.SelectedRows[0].Cells[3].Value));
        }
        /// <summary>
        /// 依据所属matter的id号,刷新TodoList
        /// </summary>
        /// <param name="mfNum">所属Matter的id号</param>
        private void refreshTodoList(int mfNum)
        {
            dgvTodoList.Rows.Clear();
            string sqlTodo = "select content from tbTodo where mfNum=" + mfNum;
            OleDbDataReader dr = OleDbHelper.ExecuteReader(sqlTodo);
            int i = 1;
            while (dr.Read())
            {
                dgvTodoList.Rows.Add(i++, dr["content"].ToString(), mfNum);
            }
            dr.Close();
        }

        private void dgvMatters_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int mfNum = Convert.ToInt32(dgvMatters.Rows[e.RowIndex].Cells[3].Value);
            refreshTodoList(mfNum);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(sql))
            {
                frmReportPrint f = new MatterManager.frmReportPrint(sql);
                f.MdiParent = this.MdiParent ;
                f.Show();
            }
        }
    }
}
