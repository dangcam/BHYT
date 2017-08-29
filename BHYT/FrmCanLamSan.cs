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
            gridControl.DataSource = dvkt.DSCanLamSan ();
        }
        private void FrmCanLamSan_Load (object sender, EventArgs e)
        {
            them = true;
            lookUpCanLamSan.Properties.DisplayMember = "TEN";
            lookUpCanLamSan.Properties.ValueMember = "ID";
            repositoryItemLookNhom.DataSource = dvkt.DSNhom ();
            repositoryItemLookNhom.ValueMember = "MA_NHOM";
            repositoryItemLookNhom.DisplayMember = "TEN_NHOM";

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
            if(txtTen.Text.Length<1)
            {
                XtraMessageBox.Show ("Nhập tên cận lâm sàn!", "Lỗi");
                return;
            }
            string err = "";
            if (them)
            {
                if (!dvkt.ThemCanLamSan (ref err, txtTen.Text))
                {
                    XtraMessageBox.Show (err, "Lỗi");
                    return;
                }
            }
            else
            {
                if (!dvkt.SuaCanLamSan (ref err,Utils.ToInt(txtId.Text), txtTen.Text))
                {
                    XtraMessageBox.Show (err, "Lỗi");
                    return;
                }
            }
            LoadData ();
        }

        private void lookUpCanLamSan_EditValueChanged (object sender, EventArgs e)
        {
            DataRowView dr = (lookUpCanLamSan.GetSelectedDataRow () as DataRowView);
            if(dr!=null)
            {
                txtId.Text = dr[0].ToString ();
                txtTen.Text = dr[1].ToString ();
                gridControlDS.DataSource = dvkt.DSCanLamSan (Utils.ToInt (txtId.Text));
                them = false;
            }
        }

        private void btnChuyen_Click (object sender, EventArgs e)
        {
            if(them==false)
            {
                DataRow dr = gridView.GetFocusedDataRow ();
                if (dr != null)
                {
                    DataRow drAdd = (gridControlDS.DataSource as DataTable).NewRow ();
                    drAdd["MA_NHOM"] = dr["MA_NHOM"];
                    drAdd["MA_DVKT"] = dr["MA_DVKT"];
                    drAdd["TEN_DVKT"] = dr["TEN_DVKT"];
                    string err = "";
                    if(!dvkt.SuaDVKTCLS(ref err,drAdd["MA_DVKT"].ToString(),Utils.ToInt(txtId.Text)))
                    {
                        XtraMessageBox.Show (err, "Lỗi");
                        return;
                    }
                    (gridControlDS.DataSource as DataTable).Rows.Add (drAdd);
                    (gridControl.DataSource as DataTable).Rows.Remove (dr);
                }
            }
        }
        private void btnTra_Click (object sender, EventArgs e)
        {
            if(them==false)
            {
                DataRow dr = gridViewDS.GetFocusedDataRow ();
                if (dr != null)
                {
                    DataRow drAdd = (gridControl.DataSource as DataTable).NewRow ();
                    drAdd["MA_NHOM"] = dr["MA_NHOM"];
                    drAdd["MA_DVKT"] = dr["MA_DVKT"];
                    drAdd["TEN_DVKT"] = dr["TEN_DVKT"];
                    string err = "";
                    if (!dvkt.SuaDVKTCLS (ref err, drAdd["MA_DVKT"].ToString (), 0))
                    {
                        XtraMessageBox.Show (err, "Lỗi");
                        return;
                    }
                    (gridControl.DataSource as DataTable).Rows.Add (drAdd);
                    (gridControlDS.DataSource as DataTable).Rows.Remove (dr);
                }
            }
        }
    }
}
