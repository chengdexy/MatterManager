namespace MatterManager
{
    partial class frmConfiguration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfiguration));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbQuest = new System.Windows.Forms.RadioButton();
            this.rbExit = new System.Windows.Forms.RadioButton();
            this.rbMini = new System.Windows.Forms.RadioButton();
            this.btnOK = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkAutoRun = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbQuest);
            this.groupBox1.Controls.Add(this.rbExit);
            this.groupBox1.Controls.Add(this.rbMini);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 111);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "点击\"关闭\"时执行";
            // 
            // rbQuest
            // 
            this.rbQuest.AutoSize = true;
            this.rbQuest.Location = new System.Drawing.Point(27, 77);
            this.rbQuest.Name = "rbQuest";
            this.rbQuest.Size = new System.Drawing.Size(83, 16);
            this.rbQuest.TabIndex = 2;
            this.rbQuest.TabStop = true;
            this.rbQuest.Text = "提示我选择";
            this.rbQuest.UseVisualStyleBackColor = true;
            // 
            // rbExit
            // 
            this.rbExit.AutoSize = true;
            this.rbExit.Location = new System.Drawing.Point(27, 55);
            this.rbExit.Name = "rbExit";
            this.rbExit.Size = new System.Drawing.Size(71, 16);
            this.rbExit.TabIndex = 1;
            this.rbExit.TabStop = true;
            this.rbExit.Text = "退出程序";
            this.rbExit.UseVisualStyleBackColor = true;
            // 
            // rbMini
            // 
            this.rbMini.AutoSize = true;
            this.rbMini.Location = new System.Drawing.Point(27, 33);
            this.rbMini.Name = "rbMini";
            this.rbMini.Size = new System.Drawing.Size(143, 16);
            this.rbMini.TabIndex = 0;
            this.rbMini.TabStop = true;
            this.rbMini.Text = "最小化程序到系统托盘";
            this.rbMini.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(116, 205);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(197, 205);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkAutoRun);
            this.groupBox2.Location = new System.Drawing.Point(12, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 70);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "开机自启动";
            // 
            // chkAutoRun
            // 
            this.chkAutoRun.AutoSize = true;
            this.chkAutoRun.Location = new System.Drawing.Point(27, 32);
            this.chkAutoRun.Name = "chkAutoRun";
            this.chkAutoRun.Size = new System.Drawing.Size(132, 16);
            this.chkAutoRun.TabIndex = 0;
            this.chkAutoRun.Text = "随系统自动运行程序";
            this.chkAutoRun.UseVisualStyleBackColor = true;
            // 
            // frmConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 236);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConfiguration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "选项";
            this.Load += new System.EventHandler(this.frmConfiguration_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbQuest;
        private System.Windows.Forms.RadioButton rbExit;
        private System.Windows.Forms.RadioButton rbMini;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkAutoRun;
    }
}