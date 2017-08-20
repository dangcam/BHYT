using BHYT.DAO;
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
    public partial class FrmTienGiuongChiTiet : Form
    {
        #region
        TienGiuongDAO tienGiuong = null;
        int maKhoa, maBS;
        string ngayYL;
        string ngayDtri;
        public int MaKhoa
        {
            get
            {
                return maKhoa;
            }

            set
            {
                maKhoa = value;
            }
        }

        public int MaBS
        {
            get
            {
                return maBS;
            }

            set
            {
                maBS = value;
            }
        }

        public string NgayYLenh
        {
            get
            {
                return ngayYL;
            }

            set
            {
                ngayYL = value;
            }
        }

        public string NgayDtri
        {
            get
            {
                return ngayDtri;
            }

            set
            {
                ngayDtri = value;
            }
        }
        #endregion
        public FrmTienGiuongChiTiet (Connection db)
        {
            InitializeComponent ();
            tienGiuong = new TienGiuongDAO (db);
        }

        private void btnChon_Click (object sender, EventArgs e)
        {
            try
            {
                string maDichVu = (lookUpLoaiGiuong.GetSelectedDataRow () as DataRowView)[0].ToString ();
                foreach(DataRowView dr in (gridControl.DataSource as DataView))
                {
                    if(dr["MA_DICH_VU"].ToString() == maDichVu)
                    {
                        MessageBox.Show ("Dịch vụ đã chọn, nhập lại số lượng!");
                        return;
                    }
                }
                DataRowView drNew = (gridControl.DataSource as DataView).AddNew ();
                drNew["MA_DICH_VU"] = (lookUpLoaiGiuong.GetSelectedDataRow () as DataRowView)[0].ToString ();
                drNew["TEN_DICH_VU"] = (lookUpLoaiGiuong.GetSelectedDataRow () as DataRowView)[1].ToString ();
                drNew["DON_GIA"] = (lookUpLoaiGiuong.GetSelectedDataRow () as DataRowView)[2].ToString ();
                drNew["DON_VI_TINH"] = (lookUpLoaiGiuong.GetSelectedDataRow () as DataRowView)[3].ToString ();
                drNew["MA_NHOM"] = (lookUpLoaiGiuong.GetSelectedDataRow () as DataRowView)[4].ToString ();
                drNew["MA_KHOA"] = (lookUpMaKhoa.GetSelectedDataRow () as DataRowView)[0].ToString ();
                drNew["MA_BAC_SI"] = (lookUpMaBS.GetSelectedDataRow () as DataRowView)[0].ToString ();
                drNew["NGAY_YL"] = dateNgayYLenh.Text;
                drNew["SO_LUONG"] = txtSoNgay.Value;
                drNew["TYLE_TT"] = 100;
                drNew["THANH_TIEN"] = txtSoNgay.Value * Convert.ToDecimal(drNew["DON_GIA"]);


                btnOK.Focus ();
                txtSoNgay.ResetText ();
            }
            catch(Exception ex)
            {
                MessageBox.Show (ex.Message);
            }
        }

        private void LoadData()
        {
            gridControl.DataSource = FrmNgoaiNoiTru.dvTienGiuong;
        }

        private void btnXoa_ButtonClick (object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            (gridControl.DataSource as DataView).Delete (gridView.GetFocusedDataSourceRowIndex());
        }

        private void FrmTienGiuongChiTiet_FormClosing (object sender, FormClosingEventArgs e)
        {
            FrmNgoaiNoiTru.dvTienGiuong = (gridControl.DataSource as DataView);
        }

        private void gridView_RowUpdated (object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        { 
            int index = gridView.GetFocusedDataSourceRowIndex ();
            try
            {
                int soluong = int.Parse ((gridControl.DataSource as DataView)[index]["SO_LUONG"].ToString ());
                int dongia = int.Parse ((gridControl.DataSource as DataView)[index]["DON_GIA"].ToString ());
                (gridControl.DataSource as DataView)[index]["THANH_TIEN"] = soluong * dongia;
            }
            catch { }
        }

        private void btnOK_Click (object sender, EventArgs e)
        {
            this.Close ();
        }


        private void lookUpLoaiGiuong_KeyPress (object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtSoNgay.Focus ();
            }
        }

        private void txtSoNgay_KeyPress (object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnChon.Focus ();
            }
        }


        private void FrmTienGiuongChiTiet_Load (object sender, EventArgs e)
        {
            dateNgayYLenh.Text = DateTime.ParseExact (NgayYLenh, "dd/MM/yyyy HH:mm", System.Globalization.CultureInfo.InvariantCulture).ToString ();

            lookUpMaKhoa.Properties.DataSource = tienGiuong.DSKhoa ();
            lookUpMaKhoa.Properties.DisplayMember = "TEN_KHOA";
            lookUpMaKhoa.Properties.ValueMember = "MA_KHOA";
            lookUpMaKhoa.ItemIndex = MaKhoa;

            lookUpMaBS.Properties.DataSource = tienGiuong.DSNhanVien ();
            lookUpMaBS.Properties.DisplayMember = "TEN_NHANVIEN";
            lookUpMaBS.Properties.ValueMember = "MA_NHANVIEN";
            lookUpMaBS.ItemIndex = MaBS;

            lookUpLoaiGiuong.Properties.DataSource = tienGiuong.DSGiuong ();
            lookUpLoaiGiuong.Properties.DisplayMember = "TEN";
            lookUpLoaiGiuong.Properties.ValueMember = "MA";
            LoadData ();
            this.ActiveControl = lookUpLoaiGiuong;
            try
            {
                txtSoNgay.Value = decimal.Parse (NgayDtri);
            }
            catch { }
        }
    }
}
