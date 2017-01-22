namespace MatterManager
{
    partial class frmAddNewTodoItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddNewTodoItem));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtStopReason = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpStop = new System.Windows.Forms.DateTimePicker();
            this.txtDoneDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDone = new System.Windows.Forms.DateTimePicker();
            this.rbStop = new System.Windows.Forms.RadioButton();
            this.rbDone = new System.Windows.Forms.RadioButton();
            this.rbDoing = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtContent);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 140);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "待办事项内容(*)：";
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(6, 20);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(403, 114);
            this.txtContent.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtStopReason);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dtpStop);
            this.groupBox2.Controls.Add(this.txtDoneDescription);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dtpDone);
            this.groupBox2.Controls.Add(this.rbStop);
            this.groupBox2.Controls.Add(this.rbDone);
            this.groupBox2.Controls.Add(this.rbDoing);
            this.groupBox2.Location = new System.Drawing.Point(12, 158);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(415, 242);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "办理状态：";
            // 
            // txtStopReason
            // 
            this.txtStopReason.Location = new System.Drawing.Point(110, 199);
            this.txtStopReason.Name = "txtStopReason";
            this.txtStopReason.Size = new System.Drawing.Size(297, 21);
            this.txtStopReason.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "中止原因(*)：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "中止日期：";
            // 
            // dtpStop
            // 
            this.dtpStop.Location = new System.Drawing.Point(110, 165);
            this.dtpStop.Name = "dtpStop";
            this.dtpStop.Size = new System.Drawing.Size(200, 21);
            this.dtpStop.TabIndex = 7;
            // 
            // txtDoneDescription
            // 
            this.txtDoneDescription.Location = new System.Drawing.Point(110, 110);
            this.txtDoneDescription.Name = "txtDoneDescription";
            this.txtDoneDescription.Size = new System.Drawing.Size(297, 21);
            this.txtDoneDescription.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "办理结果(*)：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "办结日期：";
            // 
            // dtpDone
            // 
            this.dtpDone.Location = new System.Drawing.Point(110, 76);
            this.dtpDone.Name = "dtpDone";
            this.dtpDone.Size = new System.Drawing.Size(200, 21);
            this.dtpDone.TabIndex = 3;
            // 
            // rbStop
            // 
            this.rbStop.AutoSize = true;
            this.rbStop.Location = new System.Drawing.Point(6, 141);
            this.rbStop.Name = "rbStop";
            this.rbStop.Size = new System.Drawing.Size(59, 16);
            this.rbStop.TabIndex = 2;
            this.rbStop.TabStop = true;
            this.rbStop.Text = "已中止";
            this.rbStop.UseVisualStyleBackColor = true;
            this.rbStop.Click += new System.EventHandler(this.rbStop_Click);
            // 
            // rbDone
            // 
            this.rbDone.AutoSize = true;
            this.rbDone.Location = new System.Drawing.Point(6, 49);
            this.rbDone.Name = "rbDone";
            this.rbDone.Size = new System.Drawing.Size(59, 16);
            this.rbDone.TabIndex = 1;
            this.rbDone.TabStop = true;
            this.rbDone.Text = "已办结";
            this.rbDone.UseVisualStyleBackColor = true;
            this.rbDone.Click += new System.EventHandler(this.rbDone_Click);
            // 
            // rbDoing
            // 
            this.rbDoing.AutoSize = true;
            this.rbDoing.Location = new System.Drawing.Point(6, 20);
            this.rbDoing.Name = "rbDoing";
            this.rbDoing.Size = new System.Drawing.Size(59, 16);
            this.rbDoing.TabIndex = 0;
            this.rbDoing.TabStop = true;
            this.rbDoing.Text = "办理中";
            this.rbDoing.UseVisualStyleBackColor = true;
            this.rbDoing.Click += new System.EventHandler(this.rbDoing_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(271, 406);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "保存并退出";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(352, 406);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "放弃保存";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmAddNewTodoItem
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(439, 441);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "frmAddNewTodoItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAddNewTodoItem";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAddNewTodoItem_FormClosing);
            this.Load += new System.EventHandler(this.frmAddNewTodoItem_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbStop;
        private System.Windows.Forms.RadioButton rbDone;
        private System.Windows.Forms.RadioButton rbDoing;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDone;
        private System.Windows.Forms.TextBox txtDoneDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStopReason;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpStop;
    }
}