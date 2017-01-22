using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatterManager
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        private void frmAbout_Load(object sender, EventArgs e)
        {
            //部署版本号
            string ver="0.0";
            try
            {
                ver = System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString();
            }
            catch
            {
            }
            string z = ver.Split('.')[0];
            string c = ver.Split('.')[1];
            lblVer.Text = string.Format("v{0}.{1}", z, c);

            //copyright
            DateTime last = System.IO.File.GetLastWriteTime("MatterManager.exe");
            lblLast.Text = last.ToString("yyyy-MM-dd");
        }
    }
}
