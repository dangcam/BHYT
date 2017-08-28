using BHYT.DAO;
using DevExpress.XtraEditors;
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
    public partial class FrmCanLamSan : Form
    {
        bool them = false;
        DVTKDAO dvkt;
        public FrmCanLamSan (Connection db)
        {
            InitializeComponent ();
            dvkt = new DVTKDAO (db);
        }
        private void LoadData()
        {
            lookUpCanLamSan.Properties.DataSource = dvkt.DSCLS ();
        }
        private void FrmCanLamSan_Load (object sender, EventArgs e)
        {
            them = true;
            lookUpCanLamSan.Properties.DisplayMember = "TEN";
            lookUpCanLamSan.Properties.ValueMember = "ID";
            LoadData ();
        }

        private void btnMoi_Click (object sender, EventArgs e)
        {
            them = true;
            txtId.Text = "0";
            txtTen.Text = "";
        }

        private void btnLuu_Click (object sender, EventArgs e)
        {
            string err = "";
            if(!dvkt.ThemCanLamSan(ref err, txtTen.Text))
            {
                XtraMessageBox.Show (err, "Lỗi");
                return;
            }
            LoadData ();
        }

        private void lookUpCanLamSan_EditValueChanged (object sender, EventArgs e)
        {
            DataRow dr = (lookUpCanLamSan.GetSelectedDataRow () as DataRow);
            if(dr!=null)
            {
                txtId.Text = dr[0].ToString ();
                txtTen.Text = dr[1].ToString ();
                gridControlDS.DataSource = dvkt.DSCanLamSan (Utils.ToInt (txtId.Text));
            }
        }

        private void btnTra_Click (object sender, EventArgs e)
        {

        }

        private void btnChuyen_Click (object sender, EventArgs e)
        {

        }
    }
}
