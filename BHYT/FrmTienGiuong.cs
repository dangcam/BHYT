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
    public partial class FrmTienGiuong : Form
    {
        TienGiuongDAO tien = null;
        bool luu = false;
        public FrmTienGiuong (Connection db)
        {
            InitializeComponent ();
            tien = new TienGiuongDAO (db);
        }
        private void LoadData ()
        {
            gridControl.DataSource = tien.DSTienGiuong ();
        }
        private void FrmTienGiuong_Load (object sender, EventArgs e)
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
                    TienGiuongVO b = null;
                    foreach (DataRow dtRow in data.Rows)
                    {
                        b = new TienGiuongVO ();
                        b.Ma = dtRow.ItemArray[0].ToString ();
                        b.MaKhoa = dtRow.ItemArray[1].ToString ().Split('.')[0];
                        b.MaTT37 = dtRow.ItemArray[0].ToString ();
                        b.Ten = dtRow.ItemArray[2].ToString ();
                        b.DonGia = int.Parse (dtRow.ItemArray[3].ToString ());
                        b.DonVi = "Ngày";//dtRow.ItemArray[6].ToString ();
                        b.TuNgay = DateTime.ParseExact (dtRow.ItemArray[4].ToString (), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                        b.DenNgay = DateTime.ParseExact (dtRow.ItemArray[5].ToString (), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                        b.MaNhom = dtRow[11].ToString ();
                        if (b.MaNhom == "15")
                        {
                            string err = "";
                            tien.ThemTienGiuong (ref err, b);
                            if(!string.IsNullOrEmpty(err))
                            {
                                MessageBox.Show (err);
                            }
                        }
                    }
                    LoadData ();
                }
                catch (Exception ex)
                {
                    MessageBox.Show (ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
        }

        private void gridView_RowClick (object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            DataRow dr = gridView.GetFocusedDataRow ();
            try
            {
                txtMa.ReadOnly = true;
                txtMa.Text = dr[0].ToString ();
                txtMaKhoa.Text = dr[1].ToString ();
                txtTen.Text = dr[3].ToString ();
                txtDonGia.Text = dr[4].ToString ();
                dateTuNgay.Text = dr[6].ToString ();
                dateDenNgay.Text = dr[7].ToString ();
                luu = true;
                btnLuu.Enabled = true;
            }
            catch { }
        }

        private void btnMoi_Click (object sender, EventArgs e)
        {
            txtMa.ReadOnly = false;
            txtMa.ResetText ();
            txtMaKhoa.ResetText ();
            txtTen.ResetText ();
            txtDonGia.ResetText ();
            luu = false;
            btnLuu.Enabled = true;
        }

        private void btnLuu_Click (object sender, EventArgs e)
        {
            if (txtMa.Text.Length > 0)
            {
                string err = "";
                TienGiuongVO tg = new TienGiuongVO ();
                tg.Ma = txtMa.Text;
                tg.MaKhoa = txtMaKhoa.Text;
                tg.MaNhom = "15";
                tg.DonVi = "Ngày";
                tg.Ten = txtTen.Text;
                tg.MaTT37 = "";
                tg.DonGia = int.Parse (txtDonGia.Text);
                tg.TuNgay = DateTime.ParseExact (dateTuNgay.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                tg.DenNgay = DateTime.ParseExact (dateDenNgay.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                if (luu)
                {
                    // sửa
                    if (!tien.SuaTienGiuong (ref err, tg))
                    {
                        MessageBox.Show (err);
                    }
                }
                else
                {
                    // thêm
                    if (!tien.ThemTienGiuong (ref err, tg))
                    {
                        MessageBox.Show (err);
                    }
                }
                LoadData ();
            }
        }

        private void btnXoa_Click (object sender, EventArgs e)
        {
            DataRow dr = gridView.GetFocusedDataRow ();
            DialogResult traloi;
            string err = "";
            // Hiện hộp thoại hỏi đáp 
            traloi = MessageBox.Show ("Chắc chắn bạn muốn xóa dịch vụ này?", "Trả lời",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
                try
                {
                    string ma = dr[0].ToString ();
                    if (!tien.XoaTienGiuong (ref err, ma))
                    {
                        MessageBox.Show (err);
                    }
                    LoadData ();
                }
                catch { }
        }
    }
}
