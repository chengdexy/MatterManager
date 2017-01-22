namespace MatterManager
{
    partial class frmQueryMatters
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQueryMatters));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkStop = new System.Windows.Forms.CheckBox();
            this.chkDone = new System.Windows.Forms.CheckBox();
            this.chkDoing = new System.Windows.Forms.CheckBox();
            this.txtKeyWords = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnQuery = new System.Windows.Forms.Button();
            this.chkAllDate = new System.Windows.Forms.CheckBox();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvTodoList = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMatters = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodoList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatters)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkStop);
            this.groupBox1.Controls.Add(this.chkDone);
            this.groupBox1.Controls.Add(this.chkDoing);
            this.groupBox1.Controls.Add(this.txtKeyWords);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnQuery);
            this.groupBox1.Controls.Add(this.chkAllDate);
            this.groupBox1.Controls.Add(this.dtpTo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpFrom);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(602, 99);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询条件";
            // 
            // chkStop
            // 
            this.chkStop.AutoSize = true;
            this.chkStop.Location = new System.Drawing.Point(455, 60);
            this.chkStop.Name = "chkStop";
            this.chkStop.Size = new System.Drawing.Size(60, 16);
            this.chkStop.TabIndex = 10;
            this.chkStop.Text = "已中止";
            this.chkStop.UseVisualStyleBackColor = true;
            // 
            // chkDone
            // 
            this.chkDone.AutoSize = true;
            this.chkDone.Location = new System.Drawing.Point(389, 60);
            this.chkDone.Name = "chkDone";
            this.chkDone.Size = new System.Drawing.Size(60, 16);
            this.chkDone.TabIndex = 9;
            this.chkDone.Text = "已办结";
            this.chkDone.UseVisualStyleBackColor = true;
            // 
            // chkDoing
            // 
            this.chkDoing.AutoSize = true;
            this.chkDoing.Location = new System.Drawing.Point(323, 61);
            this.chkDoing.Name = "chkDoing";
            this.chkDoing.Size = new System.Drawing.Size(60, 16);
            this.chkDoing.TabIndex = 8;
            this.chkDoing.Text = "办理中";
            this.chkDoing.UseVisualStyleBackColor = true;
            // 
            // txtKeyWords
            // 
            this.txtKeyWords.Location = new System.Drawing.Point(80, 58);
            this.txtKeyWords.Name = "txtKeyWords";
            this.txtKeyWords.Size = new System.Drawing.Size(237, 21);
            this.txtKeyWords.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "关键字：";
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(521, 33);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 40);
            this.btnQuery.TabIndex = 5;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // chkAllDate
            // 
            this.chkAllDate.AutoSize = true;
            this.chkAllDate.Location = new System.Drawing.Point(323, 25);
            this.chkAllDate.Name = "chkAllDate";
            this.chkAllDate.Size = new System.Drawing.Size(72, 16);
            this.chkAllDate.TabIndex = 4;
            this.chkAllDate.Text = "所有时间";
            this.chkAllDate.UseVisualStyleBackColor = true;
            // 
            // dtpTo
            // 
            this.dtpTo.CustomFormat = "yyyy年MM月dd日";
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(210, 20);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(107, 21);
            this.dtpTo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "-";
            // 
            // dtpFrom
            // 
            this.dtpFrom.CustomFormat = "yyyy年MM月dd日";
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(80, 20);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(107, 21);
            this.dtpFrom.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "时间段：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvTodoList);
            this.groupBox2.Controls.Add(this.dgvMatters);
            this.groupBox2.Location = new System.Drawing.Point(12, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(602, 258);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "查询结果";
            // 
            // dgvTodoList
            // 
            this.dgvTodoList.AllowUserToAddRows = false;
            this.dgvTodoList.AllowUserToDeleteRows = false;
            this.dgvTodoList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTodoList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvTodoList.Location = new System.Drawing.Point(337, 20);
            this.dgvTodoList.Name = "dgvTodoList";
            this.dgvTodoList.ReadOnly = true;
            this.dgvTodoList.RowHeadersVisible = false;
            this.dgvTodoList.RowTemplate.Height = 23;
            this.dgvTodoList.Size = new System.Drawing.Size(259, 232);
            this.dgvTodoList.TabIndex = 1;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "编号";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 60;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "内容";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 200;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "mfNum";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Visible = false;
            // 
            // dgvMatters
            // 
            this.dgvMatters.AllowUserToAddRows = false;
            this.dgvMatters.AllowUserToDeleteRows = false;
            this.dgvMatters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvMatters.Location = new System.Drawing.Point(6, 20);
            this.dgvMatters.MultiSelect = false;
            this.dgvMatters.Name = "dgvMatters";
            this.dgvMatters.ReadOnly = true;
            this.dgvMatters.RowHeadersVisible = false;
            this.dgvMatters.RowTemplate.Height = 23;
            this.dgvMatters.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMatters.Size = new System.Drawing.Size(325, 232);
            this.dgvMatters.TabIndex = 0;
            this.dgvMatters.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMatters_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "编号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 60;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "标题";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "状态";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 60;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "mfNum";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(434, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "预览/打印(&p)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(515, 381);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "关闭";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmQueryMatters
            // 
            this.AcceptButton = this.btnQuery;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(626, 418);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "frmQueryMatters";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "查询/打印";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmQueryMatters_FormClosing);
            this.Load += new System.EventHandler(this.frmQueryMatters_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodoList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatters)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkStop;
        private System.Windows.Forms.CheckBox chkDone;
        private System.Windows.Forms.CheckBox chkDoing;
        private System.Windows.Forms.TextBox txtKeyWords;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.CheckBox chkAllDate;
        private System.Windows.Forms.DataGridView dgvTodoList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridView dgvMatters;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}