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
                ConfigurationManager.AppSettings["miniWhenClose"] = "false";
            }
            else if (rbMini.Checked)
            {
                ConfigurationManager.AppSettings["miniWhenClose"] = "true";
            }
            else
            {
                ConfigurationManager.AppSettings["showDialogWhenClose"] = "true";
            }

            if (chkAutoRun.Checked)
            {
                setAutoRunRegist();
            }
            else
            {
                if (Convert.ToBoolean(ConfigurationManager.AppSettings["registed"]))
                {
                    clearAutoRunRegist();
                }
            }

            ConfigurationManager.AppSettings["autoRun"] = chkAutoRun.Checked.ToString();

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
            ConfigurationManager.AppSettings["registed"] = "false";
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
            ConfigurationManager.AppSettings["registed"] = "true";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void frmConfiguration_Load(object sender, EventArgs e)
        {
            bool mini = Convert.ToBoolean(ConfigurationManager.AppSettings["miniWhenClose"]);
            bool dlg = Convert.ToBoolean(ConfigurationManager.AppSettings["showDialogWhenClose"]);
            bool auto = Convert.ToBoolean(ConfigurationManager.AppSettings["autoRun"]);
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
