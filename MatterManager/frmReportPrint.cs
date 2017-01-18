using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using DatabaseHelpers;

namespace MatterManager
{
    public partial class frmReportPrint : Form
    {
        public frmReportPrint()
        {
            InitializeComponent();
        }

        private void frmReportPrint_Load(object sender, EventArgs e)
        {
            DataTable dtMatter = OleDbHelper.ExecuteDataTable("select id as c1,title as c2,leadername as c3,state as c4 from tbMatter");
            DataTable dtTodo = OleDbHelper.ExecuteDataTable("select mfNum as sub1,content as sub2,state as sub3 from tbTodo");
            dtMatter.TableName = "tbMatter";
            dtTodo.TableName = "tbTodo";

            this.rView.ProcessingMode = ProcessingMode.Local;
            this.rView.LocalReport.ReportPath = @"AppReport\reportMain.rdlc";
            //this.rView.LocalReport.DataSources.Clear();
            rView.LocalReport.SubreportProcessing += (a, b) => b.DataSources.Add(new ReportDataSource("dsSubReport", dtTodo)); 
            this.rView.LocalReport.DataSources.Add(new ReportDataSource("dsReportMain", dtMatter));
            this.rView.RefreshReport();
            this.rView.RefreshReport();
        }
    }
}
