namespace MatterManager
{
    partial class frmAddMatterFile
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblBeginDate = new System.Windows.Forms.Label();
            this.dtpBeginDate = new System.Windows.Forms.DateTimePicker();
            this.lblUploadFile = new System.Windows.Forms.Label();
            this.ofdUploadFile = new System.Windows.Forms.OpenFileDialog();
            this.lblPathOfUploaded = new System.Windows.Forms.Label();
            this.btnUploadFile = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblTodoItemList = new System.Windows.Forms.Label();
            this.dgvTodoItemList = new System.Windows.Forms.DataGridView();
            this.cNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancelAndClear = new System.Windows.Forms.Button();
            this.btnAddToList = new System.Windows.Forms.Button();
            this.txtNewItemContent = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnJustSave = new System.Windows.Forms.Button();
            this.btnSaveAndExit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblFileNumber = new System.Windows.Forms.Label();
            this.txtFileNumber = new System.Windows.Forms.TextBox();
            this.lblLeadman = new System.Windows.Forms.Label();
            this.cboLeadman = new System.Windows.Forms.ComboBox();
            this.txtLeadmanPost = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodoItemList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(32, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(89, 12);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "公文文件标题：";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(127, 20);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(252, 21);
            this.txtTitle.TabIndex = 2;
            // 
            // lblBeginDate
            // 
            this.lblBeginDate.AutoSize = true;
            this.lblBeginDate.Location = new System.Drawing.Point(494, 20);
            this.lblBeginDate.Name = "lblBeginDate";
            this.lblBeginDate.Size = new System.Drawing.Size(89, 12);
            this.lblBeginDate.TabIndex = 3;
            this.lblBeginDate.Text = "事务发生日期：";
            // 
            // dtpBeginDate
            // 
            this.dtpBeginDate.Location = new System.Drawing.Point(589, 20);
            this.dtpBeginDate.Name = "dtpBeginDate";
            this.dtpBeginDate.Size = new System.Drawing.Size(200, 21);
            this.dtpBeginDate.TabIndex = 4;
            // 
            // lblUploadFile
            // 
            this.lblUploadFile.AutoSize = true;
            this.lblUploadFile.Location = new System.Drawing.Point(32, 135);
            this.lblUploadFile.Name = "lblUploadFile";
            this.lblUploadFile.Size = new System.Drawing.Size(101, 12);
            this.lblUploadFile.TabIndex = 5;
            this.lblUploadFile.Text = "上传此公文文件：";
            // 
            // lblPathOfUploaded
            // 
            this.lblPathOfUploaded.AutoSize = true;
            this.lblPathOfUploaded.Location = new System.Drawing.Point(32, 161);
            this.lblPathOfUploaded.Name = "lblPathOfUploaded";
            this.lblPathOfUploaded.Size = new System.Drawing.Size(173, 12);
            this.lblPathOfUploaded.TabIndex = 6;
            this.lblPathOfUploaded.Text = "请点击右侧按钮上传文件电子版";
            // 
            // btnUploadFile
            // 
            this.btnUploadFile.Location = new System.Drawing.Point(127, 130);
            this.btnUploadFile.Name = "btnUploadFile";
            this.btnUploadFile.Size = new System.Drawing.Size(75, 23);
            this.btnUploadFile.TabIndex = 7;
            this.btnUploadFile.Text = "浏览...";
            this.btnUploadFile.UseVisualStyleBackColor = true;
            this.btnUploadFile.Click += new System.EventHandler(this.btnUploadFile_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(494, 68);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(101, 12);
            this.lblDescription.TabIndex = 8;
            this.lblDescription.Text = "事务描述(备注)：";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(589, 68);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(252, 115);
            this.txtDescription.TabIndex = 9;
            // 
            // lblTodoItemList
            // 
            this.lblTodoItemList.AutoSize = true;
            this.lblTodoItemList.Location = new System.Drawing.Point(17, 201);
            this.lblTodoItemList.Name = "lblTodoItemList";
            this.lblTodoItemList.Size = new System.Drawing.Size(89, 12);
            this.lblTodoItemList.TabIndex = 10;
            this.lblTodoItemList.Text = "待办事项清单：";
            // 
            // dgvTodoItemList
            // 
            this.dgvTodoItemList.AllowUserToAddRows = false;
            this.dgvTodoItemList.AllowUserToDeleteRows = false;
            this.dgvTodoItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTodoItemList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cNumber,
            this.cContent});
            this.dgvTodoItemList.Location = new System.Drawing.Point(112, 201);
            this.dgvTodoItemList.MultiSelect = false;
            this.dgvTodoItemList.Name = "dgvTodoItemList";
            this.dgvTodoItemList.ReadOnly = true;
            this.dgvTodoItemList.RowTemplate.Height = 23;
            this.dgvTodoItemList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvTodoItemList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTodoItemList.Size = new System.Drawing.Size(341, 272);
            this.dgvTodoItemList.TabIndex = 11;
            // 
            // cNumber
            // 
            this.cNumber.HeaderText = "序号";
            this.cNumber.Name = "cNumber";
            this.cNumber.ReadOnly = true;
            // 
            // cContent
            // 
            this.cContent.HeaderText = "事项内容";
            this.cContent.Name = "cContent";
            this.cContent.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtLeadmanPost);
            this.groupBox1.Controls.Add(this.cboLeadman);
            this.groupBox1.Controls.Add(this.lblLeadman);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnCancelAndClear);
            this.groupBox1.Controls.Add(this.btnAddToList);
            this.groupBox1.Controls.Add(this.txtNewItemContent);
            this.groupBox1.Location = new System.Drawing.Point(460, 201);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 272);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "新增待办事项：";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(143, 236);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "删除选中项";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancelAndClear
            // 
            this.btnCancelAndClear.Location = new System.Drawing.Point(273, 236);
            this.btnCancelAndClear.Name = "btnCancelAndClear";
            this.btnCancelAndClear.Size = new System.Drawing.Size(102, 23);
            this.btnCancelAndClear.TabIndex = 2;
            this.btnCancelAndClear.Text = "放弃并清空";
            this.btnCancelAndClear.UseVisualStyleBackColor = true;
            this.btnCancelAndClear.Click += new System.EventHandler(this.btnCancelAndClear_Click);
            // 
            // btnAddToList
            // 
            this.btnAddToList.Location = new System.Drawing.Point(6, 236);
            this.btnAddToList.Name = "btnAddToList";
            this.btnAddToList.Size = new System.Drawing.Size(109, 23);
            this.btnAddToList.TabIndex = 1;
            this.btnAddToList.Text = "←新增至清单";
            this.btnAddToList.UseVisualStyleBackColor = true;
            this.btnAddToList.Click += new System.EventHandler(this.btnAddToList_Click);
            // 
            // txtNewItemContent
            // 
            this.txtNewItemContent.Location = new System.Drawing.Point(6, 54);
            this.txtNewItemContent.Multiline = true;
            this.txtNewItemContent.Name = "txtNewItemContent";
            this.txtNewItemContent.Size = new System.Drawing.Size(369, 176);
            this.txtNewItemContent.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(685, 587);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "清空所有";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnJustSave
            // 
            this.btnJustSave.Location = new System.Drawing.Point(604, 587);
            this.btnJustSave.Name = "btnJustSave";
            this.btnJustSave.Size = new System.Drawing.Size(75, 23);
            this.btnJustSave.TabIndex = 16;
            this.btnJustSave.Text = "保存后继续";
            this.btnJustSave.UseVisualStyleBackColor = true;
            this.btnJustSave.Click += new System.EventHandler(this.btnJustSave_Click);
            // 
            // btnSaveAndExit
            // 
            this.btnSaveAndExit.Location = new System.Drawing.Point(523, 587);
            this.btnSaveAndExit.Name = "btnSaveAndExit";
            this.btnSaveAndExit.Size = new System.Drawing.Size(75, 23);
            this.btnSaveAndExit.TabIndex = 17;
            this.btnSaveAndExit.Text = "保存并退出";
            this.btnSaveAndExit.UseVisualStyleBackColor = true;
            this.btnSaveAndExit.Click += new System.EventHandler(this.btnSaveAndExit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(766, 587);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "放弃并退出";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblFileNumber
            // 
            this.lblFileNumber.AutoSize = true;
            this.lblFileNumber.Location = new System.Drawing.Point(32, 68);
            this.lblFileNumber.Name = "lblFileNumber";
            this.lblFileNumber.Size = new System.Drawing.Size(65, 12);
            this.lblFileNumber.TabIndex = 19;
            this.lblFileNumber.Text = "公文文号：";
            // 
            // txtFileNumber
            // 
            this.txtFileNumber.Location = new System.Drawing.Point(127, 68);
            this.txtFileNumber.Name = "txtFileNumber";
            this.txtFileNumber.Size = new System.Drawing.Size(252, 21);
            this.txtFileNumber.TabIndex = 20;
            // 
            // lblLeadman
            // 
            this.lblLeadman.AutoSize = true;
            this.lblLeadman.Location = new System.Drawing.Point(6, 29);
            this.lblLeadman.Name = "lblLeadman";
            this.lblLeadman.Size = new System.Drawing.Size(113, 12);
            this.lblLeadman.TabIndex = 4;
            this.lblLeadman.Text = "选择或输入牵头人：";
            // 
            // cboLeadman
            // 
            this.cboLeadman.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboLeadman.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboLeadman.FormattingEnabled = true;
            this.cboLeadman.Location = new System.Drawing.Point(125, 26);
            this.cboLeadman.Name = "cboLeadman";
            this.cboLeadman.Size = new System.Drawing.Size(102, 20);
            this.cboLeadman.TabIndex = 5;
            // 
            // txtLeadmanPost
            // 
            this.txtLeadmanPost.Location = new System.Drawing.Point(229, 25);
            this.txtLeadmanPost.Name = "txtLeadmanPost";
            this.txtLeadmanPost.Size = new System.Drawing.Size(100, 21);
            this.txtLeadmanPost.TabIndex = 6;
            // 
            // frmAddMatterFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 662);
            this.Controls.Add(this.txtFileNumber);
            this.Controls.Add(this.lblFileNumber);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveAndExit);
            this.Controls.Add(this.btnJustSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvTodoItemList);
            this.Controls.Add(this.lblTodoItemList);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.btnUploadFile);
            this.Controls.Add(this.lblPathOfUploaded);
            this.Controls.Add(this.lblUploadFile);
            this.Controls.Add(this.dtpBeginDate);
            this.Controls.Add(this.lblBeginDate);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmAddMatterFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "新建来自公文的督办事务";
            this.Load += new System.EventHandler(this.frmAddMatterFile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodoItemList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblBeginDate;
        private System.Windows.Forms.DateTimePicker dtpBeginDate;
        private System.Windows.Forms.Label lblUploadFile;
        private System.Windows.Forms.OpenFileDialog ofdUploadFile;
        private System.Windows.Forms.Label lblPathOfUploaded;
        private System.Windows.Forms.Button btnUploadFile;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblTodoItemList;
        private System.Windows.Forms.DataGridView dgvTodoItemList;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn cContent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancelAndClear;
        private System.Windows.Forms.Button btnAddToList;
        private System.Windows.Forms.TextBox txtNewItemContent;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnJustSave;
        private System.Windows.Forms.Button btnSaveAndExit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblFileNumber;
        private System.Windows.Forms.TextBox txtFileNumber;
        private System.Windows.Forms.ComboBox cboLeadman;
        private System.Windows.Forms.Label lblLeadman;
        private System.Windows.Forms.TextBox txtLeadmanPost;
    }
}