namespace MatterManager
{
    partial class frmMatterManager
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
            this.dgvMatterList = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvTodoList = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvHistoryList = new System.Windows.Forms.DataGridView();
            this.todo编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.内容 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.todo状态 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mfNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.标题 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.开始日期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.状态 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.history编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.联系日期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.反馈内容 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.history_mfNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatterList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodoList)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoryList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMatterList
            // 
            this.dgvMatterList.AllowUserToAddRows = false;
            this.dgvMatterList.AllowUserToDeleteRows = false;
            this.dgvMatterList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatterList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.编号,
            this.标题,
            this.开始日期,
            this.状态});
            this.dgvMatterList.Location = new System.Drawing.Point(6, 20);
            this.dgvMatterList.Name = "dgvMatterList";
            this.dgvMatterList.ReadOnly = true;
            this.dgvMatterList.RowTemplate.Height = 23;
            this.dgvMatterList.Size = new System.Drawing.Size(663, 147);
            this.dgvMatterList.TabIndex = 0;
            this.dgvMatterList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMatterList_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvMatterList);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(675, 180);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "督办事务列表：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvTodoList);
            this.groupBox2.Location = new System.Drawing.Point(12, 198);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(675, 180);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "待办事项详情：";
            // 
            // dgvTodoList
            // 
            this.dgvTodoList.AllowUserToAddRows = false;
            this.dgvTodoList.AllowUserToDeleteRows = false;
            this.dgvTodoList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTodoList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.todo编号,
            this.内容,
            this.todo状态,
            this.mfNum});
            this.dgvTodoList.Location = new System.Drawing.Point(6, 20);
            this.dgvTodoList.Name = "dgvTodoList";
            this.dgvTodoList.ReadOnly = true;
            this.dgvTodoList.RowTemplate.Height = 23;
            this.dgvTodoList.Size = new System.Drawing.Size(663, 147);
            this.dgvTodoList.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvHistoryList);
            this.groupBox3.Location = new System.Drawing.Point(12, 384);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(675, 180);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "督办反馈记录：";
            // 
            // dgvHistoryList
            // 
            this.dgvHistoryList.AllowUserToAddRows = false;
            this.dgvHistoryList.AllowUserToDeleteRows = false;
            this.dgvHistoryList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistoryList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.history编号,
            this.联系日期,
            this.反馈内容,
            this.history_mfNum});
            this.dgvHistoryList.Location = new System.Drawing.Point(3, 17);
            this.dgvHistoryList.Name = "dgvHistoryList";
            this.dgvHistoryList.ReadOnly = true;
            this.dgvHistoryList.RowTemplate.Height = 23;
            this.dgvHistoryList.Size = new System.Drawing.Size(663, 147);
            this.dgvHistoryList.TabIndex = 0;
            // 
            // todo编号
            // 
            this.todo编号.HeaderText = "编号";
            this.todo编号.Name = "todo编号";
            this.todo编号.ReadOnly = true;
            // 
            // 内容
            // 
            this.内容.HeaderText = "内容";
            this.内容.Name = "内容";
            this.内容.ReadOnly = true;
            // 
            // todo状态
            // 
            this.todo状态.HeaderText = "状态";
            this.todo状态.Name = "todo状态";
            this.todo状态.ReadOnly = true;
            // 
            // mfNum
            // 
            this.mfNum.HeaderText = "mfNum";
            this.mfNum.Name = "mfNum";
            this.mfNum.ReadOnly = true;
            this.mfNum.Visible = false;
            // 
            // 编号
            // 
            this.编号.HeaderText = "编号";
            this.编号.Name = "编号";
            this.编号.ReadOnly = true;
            // 
            // 标题
            // 
            this.标题.HeaderText = "标题";
            this.标题.Name = "标题";
            this.标题.ReadOnly = true;
            // 
            // 开始日期
            // 
            this.开始日期.HeaderText = "开始日期";
            this.开始日期.Name = "开始日期";
            this.开始日期.ReadOnly = true;
            // 
            // 状态
            // 
            this.状态.HeaderText = "状态";
            this.状态.Name = "状态";
            this.状态.ReadOnly = true;
            // 
            // history编号
            // 
            this.history编号.HeaderText = "编号";
            this.history编号.Name = "history编号";
            this.history编号.ReadOnly = true;
            // 
            // 联系日期
            // 
            this.联系日期.HeaderText = "联系日期";
            this.联系日期.Name = "联系日期";
            this.联系日期.ReadOnly = true;
            // 
            // 反馈内容
            // 
            this.反馈内容.HeaderText = "反馈内容";
            this.反馈内容.Name = "反馈内容";
            this.反馈内容.ReadOnly = true;
            // 
            // history_mfNum
            // 
            this.history_mfNum.HeaderText = "history_mfNum";
            this.history_mfNum.Name = "history_mfNum";
            this.history_mfNum.ReadOnly = true;
            this.history_mfNum.Visible = false;
            // 
            // frmMatterManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 585);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMatterManager";
            this.Text = "督办事务管理：";
            this.Load += new System.EventHandler(this.frmMatterManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatterList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodoList)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoryList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMatterList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvTodoList;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvHistoryList;
        private System.Windows.Forms.DataGridViewTextBoxColumn 编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 标题;
        private System.Windows.Forms.DataGridViewTextBoxColumn 开始日期;
        private System.Windows.Forms.DataGridViewTextBoxColumn 状态;
        private System.Windows.Forms.DataGridViewTextBoxColumn todo编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 内容;
        private System.Windows.Forms.DataGridViewTextBoxColumn todo状态;
        private System.Windows.Forms.DataGridViewTextBoxColumn mfNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn history编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 联系日期;
        private System.Windows.Forms.DataGridViewTextBoxColumn 反馈内容;
        private System.Windows.Forms.DataGridViewTextBoxColumn history_mfNum;
    }
}