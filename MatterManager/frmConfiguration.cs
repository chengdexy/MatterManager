using MatterManager.Properties;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConfigurationHelpers;

namespace MatterManager
{
    public partial class frmConfiguration : Form
    {
        public frmConfiguration()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (rbExit.Checked)
            {
                ConfigurationHelper.UpdateKey("miniWhenClose", "false");
            }
            else if (rbMini.Checked)
            {
                ConfigurationHelper.UpdateKey("miniWhenClose", "true");
            }
            else
            {
                ConfigurationHelper.UpdateKey("showDialogWhenClose", "true");
            }

            if (chkAutoRun.Checked)
            {
                setAutoRunRegist();
            }
            else
            {
                if (Convert.ToBoolean(ConfigurationHelper.GetValue("registed")))
                {
                    clearAutoRunRegist();
                }
            }

            ConfigurationHelper.UpdateKey("autoRun", chkAutoRun.Checked.ToString().ToLower());

            this.Close();
            this.Dispose();
        }

        private void clearAutoRunRegist()
        {
            RegistryKey regkey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            string publisherName = Application.CompanyName;
            string productName = Application.ProductName;
            string allProgramsPath = Environment.GetFolderPath(Environment.SpecialFolder.Programs);
            string shortcutPath = Path.Combine(allProgramsPath, publisherName);
            shortcutPath = Path.Combine(shortcutPath, productName) + ".appref - ms";
            regkey.DeleteValue("MatterManager", false);
            regkey.Close();
            ConfigurationHelper.UpdateKey("registed", "false");
        }

        private void setAutoRunRegist()
        {
            RegistryKey regkey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            string publisherName = "Mr.X";
            string productName = "MatterManager";
            string allProgramsPath = Environment.GetFolderPath(Environment.SpecialFolder.Programs);
            string shortcutPath = Path.Combine(allProgramsPath, publisherName);
            shortcutPath = Path.Combine(shortcutPath, productName) + ".appref - ms";
            regkey.DeleteSubKey("MatterManager", false);//delete old key if exists
            regkey.SetValue("MatterManager", shortcutPath);
            regkey.Close();
            ConfigurationHelper.UpdateKey("registed", "true");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void frmConfiguration_Load(object sender, EventArgs e)
        {
            bool mini = Convert.ToBoolean(ConfigurationHelper.GetValue("miniWhenClose"));
            bool dlg = Convert.ToBoolean(ConfigurationHelper.GetValue("showDialogWhenClose"));
            bool auto = Convert.ToBoolean(ConfigurationHelper.GetValue("autoRun"));
            if (mini)
            {
                rbMini.Checked = true;
            }
            else if (dlg)
            {
                rbQuest.Checked = true;
            }
            else
            {
                rbExit.Checked = true;
            }
            chkAutoRun.Checked = auto;

        }
    }
}
