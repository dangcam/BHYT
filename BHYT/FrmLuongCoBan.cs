using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BHYT
{
    public partial class FrmLuongCoBan : Form
    {
        ReadConfig readConfig = new ReadConfig ();
        public FrmLuongCoBan ()
        {
            InitializeComponent ();
        }

        private void FrmLuongCoBan_Load (object sender, EventArgs e)
        {
            txtLuongCoBan.Text = AppConfig.LuongCoBan.ToString();
        }

        private void btnOK_Click (object sender, EventArgs e)
        {
            AppConfig.LuongCoBan = int.Parse(txtLuongCoBan.Text);
            readConfig.Write ();
            this.Close ();
        }
    }
}
