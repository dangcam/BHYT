using BHYT.DAO;
using BHYT.VO;
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
    public partial class FrmVTYT : Form
    {
        VTYTDAO vtyt;
        bool luu = false;
        public FrmVTYT (Connection db)
        {
            InitializeComponent ();
            vtyt = new VTYTDAO (db);
        }
        private void LoadData()
        {
            gridControl.DataSource = vtyt.DSVTYT ();
        }

        private void FrmVTYT_Load (object sender, EventArgs e)
        {
            LoadData ();
            btnLuu.Enabled = false;
        }

        private void bntNhapExcel_Click (object sender, EventArgs e)
        {
            DialogResult dr = ImportExcel.openDialog ();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    DataTable data = ImportExcel.OpenFile ();
                    VTYTVO b = null;
                    foreach (DataRow dtRow in data.Rows)
                    {
                        b = new VTYTVO ();
                        b.MaVTY = dtRow.ItemArray[1].ToString ();
                        b.TenVTYT = dtRow.ItemArray[2].ToString ();
                        b.TenBV = dtRow.ItemArray[3].ToString ();
                        try
                        {
                            b.DonGia = int.Parse (dtRow.ItemArray[4].ToString ().Replace (",", ""));
                        }
                        catch { b.DonGia = 0; }
                        b.DonViTinh = dtRow.ItemArray[5].ToString ();
                        b.QuyetDinh = dtRow.ItemArray[6].ToString ();
                        b.CongBo = dtRow[7].ToString ();
                        b.MaNhom = "10";
                        string err = "";
                        vtyt.ThemVTYT(ref err, b);
                    }
                    LoadData ();
                }
                catch (Exception ex)
                {
                    MessageBox.Show (ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
        }

        private void gridView_Click (object sender, EventArgs e)
        {
            try
            {
                txtMaVatTu.ReadOnly = true;
                txtTenBV.ReadOnly = true;
                txtTenVT.ReadOnly = true;
                luu = true;
                DataRow dr = gridView.GetFocusedDataRow ();
                txtMaVatTu.Text = dr["MA_VTYT"].ToString ();
                txtTenVT.Text = dr["TEN_VTYT"].ToString ();
                txtTenBV.Text = dr["TEN_BV"].ToString ();
                txtDonGia.Text = dr["DON_GIA"].ToString ();
                txtDonViTinh.Text = dr["DON_VI_TINH"].ToString ();
                txtQuyetDinh.Text = dr["QUYET_DINH"].ToString ();
                txtCongBo.Text = dr["CONG_BO"].ToString ();
                btnLuu.Enabled = true;
            }
            catch { }
        }

        private void btnMoi_Click (object sender, EventArgs e)
        {
            txtMaVatTu.ReadOnly = false;
            txtTenBV.ReadOnly = false;
            txtTenVT.ReadOnly = false;
            luu = false;

            txtMaVatTu.Text ="";
            txtTenVT.Text = "";
            txtTenBV.Text = "";
            txtDonGia.Text = "";
            txtDonViTinh.Text = "";
            txtQuyetDinh.Text = "";
            txtCongBo.Text = "";
            btnLuu.Enabled = true;
        }

        private void btnLuu_Click (object sender, EventArgs e)
        {
            if(txtMaVatTu.Text.Length==0 || txtTenVT.Text.Length == 0 ||txtTenBV.Text.Length==0||
                txtDonGia.Text.Length==0 ||txtDonViTinh.Text.Length==0)
            {
                MessageBox.Show ("Nhập các ô còn thiếu!");
                return;
            }
            try
            {
                VTYTVO vt = new VTYTVO ();
                vt.TenVTYT = txtTenVT.Text;
                vt.MaVTY = txtMaVatTu.Text;
                vt.TenBV = txtTenBV.Text;
                vt.DonGia = int.Parse (txtDonGia.Text);
                vt.DonViTinh = txtDonViTinh.Text;
                vt.QuyetDinh = txtQuyetDinh.Text;
                vt.CongBo = txtCongBo.Text;
                vt.MaNhom = "10";
                string err = "";
                if (luu)
                {
                    if (!vtyt.SuaVTYT (ref err, vt))
                    {
                        MessageBox.Show (err);
                        return;
                    }
                    LoadData ();
                }else
                {
                    if (!vtyt.ThemVTYT (ref err, vt))
                    {
                        MessageBox.Show (err);
                        return;
                    }
                    LoadData ();
                }
            }
            catch {
                MessageBox.Show ("Dữ liệu nhập sai!");
            }
        }

        private void btnXoa_Click (object sender, EventArgs e)
        {
            DataRow dr = gridView.GetFocusedDataRow ();
            DialogResult traloi;
            string err = "";
            // Hiện hộp thoại hỏi đáp 
            traloi = MessageBox.Show ("Chắc chắn bạn muốn xóa VTYT này?", "Trả lời",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
                try
                {
                    string ma = dr["MA_VTYT"].ToString ();
                    string ten = dr["TEN_VTYT"].ToString ();
                    string tenBV = dr["TEN_BV"].ToString ();
                    if (!vtyt.XoaVTYT (ref err, ma,ten,tenBV))
                    {
                        MessageBox.Show (err);
                    }
                    LoadData ();
                }
                catch { }
        }
    }
}
