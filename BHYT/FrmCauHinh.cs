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
    public partial class FrmCauHinh : Form
    {
        ReadConfig readConfig;
        public FrmCauHinh ()
        {
            InitializeComponent ();
            readConfig = new ReadConfig ();
        }

        private void btnLuu_Click (object sender, EventArgs e)
        {
            AppConfig.ServerName = txtServerName.Text;
            AppConfig.Database = txtDatabaseName.Text;
            AppConfig.Username = txtLogin.Text;
            AppConfig.Password = txtPassword.Text;
            AppConfig.SoPhong = Utils.ToInt (txtSoPhong.Text);
            readConfig.Write ();
            this.Close ();
        }

        private void FrmCauHinh_Load (object sender, EventArgs e)
        {
            txtServerName.Text = AppConfig.ServerName;
            txtDatabaseName.Text = AppConfig.Database;
            txtLogin.Text = AppConfig.Username;
            txtPassword.Text = AppConfig.Password;
            txtSoPhong.Text = AppConfig.SoPhong.ToString ();
        }
    }
}
