using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BHYT
{
    public partial class FrmDangNhap : Form
    {
        FrmMain frmMain;
        ReadConfig read;
        public FrmDangNhap ()
        {
            InitializeComponent ();
            frmMain = new FrmMain (this);
        }

        private void FrmDangNhap_Load (object sender, EventArgs e)
        {
            //
            Process p = new Process ();
            p.StartInfo = new ProcessStartInfo ("Update.exe");
            p.StartInfo.WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory;
            p.StartInfo.CreateNoWindow = true;
            p.Start ();
            //
            read = new ReadConfig ();
            read.ReadLogin ();
            if(AppConfig.Code_user == "1")
            {
                checkNho.Checked = true;
                txtTenDN.Text = AppConfig.User;
                txtMatKhau.Text = AppConfig.Pass;
            }
            else
            {
                checkNho.Checked = false;
                txtMatKhau.ResetText ();
                txtTenDN.ResetText ();
            }
            this.ActiveControl = txtTenDN;
        }

        private void btnOK_Click (object sender, EventArgs e)
        {      
            if(txtTenDN.Text.Length <1)
            {
                this.lblThongBao.ForeColor = System.Drawing.Color.FromArgb (((int) (((byte) (185)))), ((int) (((byte) (29)))), ((int) (((byte) (71)))));
                lblThongBao.Text = "Chưa nhập tên đăng nhập!";
                txtTenDN.Focus ();
                return;
            }
            if (txtMatKhau.Text.Length < 1)
            {
                this.lblThongBao.ForeColor = System.Drawing.Color.FromArgb (((int) (((byte) (185)))), ((int) (((byte) (29)))), ((int) (((byte) (71)))));
                lblThongBao.Text = "Chưa nhập mật khẩu!";
                txtMatKhau.Focus ();
                return;
            }
            if(AppConfig.User == txtTenDN.Text && AppConfig.Pass == txtMatKhau.Text)
            {
                AppConfig.Code_user = checkNho.Checked ? "1" : "0";
                try
                {
                    read.WriteLogin ();
                }
                catch { }
                // Đăng nhập
                this.lblThongBao.ForeColor = System.Drawing.Color.FromArgb (((int) (((byte) (239)))), ((int) (((byte) (244)))), ((int) (((byte) (255)))));
                this.lblThongBao.Text = "Nhập tên đăng nhập và mật khẩu";
                this.Hide ();

                frmMain.ShowDialog ();
                // Thoát
                if (AppConfig.Code_user == "1")
                {
                    checkNho.Checked = true;
                    txtTenDN.Text = AppConfig.User;
                    txtMatKhau.Text = AppConfig.Pass;
                }
                else
                {
                    checkNho.Checked = false;
                    txtMatKhau.ResetText ();
                    txtTenDN.ResetText ();
                }
            }
            else
            {
                this.lblThongBao.ForeColor = System.Drawing.Color.FromArgb (((int) (((byte) (185)))), ((int) (((byte) (29)))), ((int) (((byte) (71)))));
                lblThongBao.Text = "Tên đăng nhập hoặc mật khẩu không đúng!";
                txtTenDN.Focus ();
                return;
            }
        }

        private void btnExit_Click (object sender, EventArgs e)
        {
            this.Close ();
        }

        private void txtTenDN_KeyPress (object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar ==13)
            {
                if(txtTenDN.Text.Length>1)
                {
                    txtMatKhau.Focus ();
                }
            }
        }

        private void txtMatKhau_KeyPress (object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (txtMatKhau.Text.Length > 1)
                {
                    btnOK.Focus ();
                }
            }
        }
    }
}
