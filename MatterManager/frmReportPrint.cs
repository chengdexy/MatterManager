using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using DatabaseHelpers;

namespace MatterManager
{
    public partial class frmReportPrint : Form
    {
        private static string sqlStr = "";

        public frmReportPrint(string sql)
        {
            sqlStr = sql;
            InitializeComponent();
        }

        private void frmReportPrint_Load(object sender, EventArgs e)
        {
            DataTable dtMatter = OleDbHelper.ExecuteDataTable(sqlStr);
            dtMatter.TableName = "tbMatter";

            this.rView.ProcessingMode = ProcessingMode.Local;
            this.rView.LocalReport.ReportPath = @"AppReport\reportMain.rdlc";
            this.rView.LocalReport.DataSources.Clear();
            this.rView.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(LocalReport_SubreportProcessing);
            this.rView.LocalReport.DataSources.Add(new ReportDataSource("dsReportMain", dtMatter));
            this.rView.RefreshReport();
            this.rView.RefreshReport();
        }

        void LocalReport_SubreportProcessing(object sender, SubreportProcessingEventArgs e)
        {
            if (e.ReportPath == "reportSub")
            {
                DataTable dtTodo = OleDbHelper.ExecuteDataTable("select mfNum,content from tbTodo");
                dtTodo.TableName = "tbTodo";
                e.DataSources.Clear();
                e.DataSources.Add(new ReportDataSource("dsSubReport", dtTodo));
            }
            else if (e.ReportPath=="reportHistory")
            {
                DataTable dtHistory = OleDbHelper.ExecuteDataTable("select top 1 mfNum,result from tbHistory order by connectDate");
                dtHistory .TableName = "tbHistory";
                e.DataSources.Clear();
                e.DataSources.Add(new ReportDataSource("dsHistory", dtHistory ));
            }
            
        }
    }
}
