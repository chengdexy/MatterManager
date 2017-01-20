namespace MatterManager
{
    partial class frmReportPrint
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportPrint));
            this.dsReport = new MatterManager.dsReport();
            this.dtReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rView = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.dsReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtReportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dsReport
            // 
            this.dsReport.DataSetName = "dsReport";
            this.dsReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtReportBindingSource
            // 
            this.dtReportBindingSource.DataMember = "dtReport";
            this.dtReportBindingSource.DataSource = this.dsReport;
            // 
            // rView
            // 
            this.rView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rView.Location = new System.Drawing.Point(0, 0);
            this.rView.Name = "rView";
            this.rView.Size = new System.Drawing.Size(826, 570);
            this.rView.TabIndex = 0;
            // 
            // frmReportPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 570);
            this.Controls.Add(this.rView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReportPrint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "打印预览";
            this.Load += new System.EventHandler(this.frmReportPrint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtReportBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource dtReportBindingSource;
        private dsReport dsReport;
        private Microsoft.Reporting.WinForms.ReportViewer rView;
    }
}