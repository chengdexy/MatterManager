using MatterManager.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConfigurationHelpers;

namespace MatterManager
{
    public partial class frmMessage : Form
    {
        string frmTitle = "";

        public frmMessage(string title)
        {
            frmTitle = title;
            InitializeComponent();
        }

        private void frmMessage_Load(object sender, EventArgs e)
        {
            if (!Convert.ToBoolean(ConfigurationHelper.GetValue("showDialogWhenClose")))
            {
                if (Convert.ToBoolean(ConfigurationHelper.GetValue("miniWhenClose")))
                {
                    this.DialogResult = DialogResult.Abort;
                }
                else
                {
                    this.DialogResult = DialogResult.OK;
                }
                this.Close();
                this.Dispose();
            }
            else
            {
                this.Text = frmTitle;
                rbMini.Checked = true;
                rbExit.Checked = false;
                chkRemember.Checked = false;
            }

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = checkRadioButtons();

            if (chkRemember.Checked)
            {
                saveChooseToConfig();
            }

            this.Close();
            this.Dispose();
        }

        private DialogResult checkRadioButtons()
        {
            if (rbMini.Checked == true)
            {
                return DialogResult.Abort; //使用Abort标签标记选择最小化的操作
            }
            else
            {
                return DialogResult.OK;    //使用OK标签标记选择退出程序的操作
            }
        }

        private void saveChooseToConfig()
        {
            ConfigurationHelper.UpdateKey("showDialogWhenClose", "false");
            if (this.DialogResult == DialogResult.Abort)
            {
                ConfigurationHelper.UpdateKey("miniWhenClose", "true");
            }
            else
            {
                ConfigurationHelper.UpdateKey("miniWhenClose", "false");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
            this.Dispose();
        }
    }
}
