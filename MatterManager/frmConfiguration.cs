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
            if (rbExit.Checked )
            {
                ConfigurationManager.AppSettings["miniWhenClose"] = "false";
            }
            else if (rbMini.Checked )
            {
                ConfigurationManager.AppSettings["miniWhenClose"] = "true";
            }
            else
            {
                ConfigurationManager.AppSettings["showDialogWhenClose"] = "true";
            }
            this.Close();
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
