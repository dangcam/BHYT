using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BHYT
{
    public partial class FrmMatKhau : Form
    {
        ReadConfig read;
        public FrmMatKhau ()
        {
            InitializeComponent ();
            read = new ReadConfig ();
        }

        private void btnCapNhat_Click (object sender, EventArgs e)
        {
            if(AppConfig.Pass == txtMKCu.Text)
            {
                AppConfig.Pass = txtMKMoi.Text;
                read.WriteLogin ();
                this.Close ();
            }
            else
            {
                MessageBox.Show ("Mật khẩu cũ không đúng!");
                txtMKCu.Focus ();
            }
        }
    }
}
