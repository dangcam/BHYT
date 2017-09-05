using BHYT.DAO;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace BHYT
{
    public partial class FrmThuocDVKT : Form
    {
        #region
        ThuocDAO thuoc;
        DataTable dataThuoc, dataDVKT, dataVTYT;
        int maKhoa, maBS;
        string ngayYLenh;
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

        public string DateYLenh
        {
            get
            {
                return ngayYLenh;
            }

            set
            {
                ngayYLenh = value;
            }
        }
        #endregion
        private void cbLoaiChiPhi_SelectedIndexChanged (object sender, EventArgs e)
        {
            //this.lookUpLoaiChiPhi.Properties.Columns.Clear ();
            this.searchLookUpEditView.Columns.Clear ();
            if (cbLoaiChiPhi.SelectedIndex == 0)
            {          

                this.searchLookUpEditView.Columns.AddRange (new DevExpress.XtraGrid.Columns.GridColumn[] {
                this.MaThuoc,
                this.gridCThuoc,
                this.HamLuong,
                this.gridCDonGia});
                this.MaThuoc.Visible = true;
                this.MaThuoc.VisibleIndex = 0;
                this.MaThuoc.Width = 40;
                this.gridCThuoc.Visible = true;
                this.gridCThuoc.VisibleIndex = 1;
                this.gridCThuoc.Width = 160;
                this.HamLuong.Visible = true;
                this.HamLuong.VisibleIndex = 2;
                this.HamLuong.Width = 60;
                this.gridCDonGia.Visible = true;
                this.gridCDonGia.VisibleIndex = 3;
                this.gridCDonGia.Width = 40;

                lookUpLoaiChiPhi.Properties.DataSource = dataThuoc;
                lookUpLoaiChiPhi.Properties.DisplayMember = "TEN_THUOC";
                //lookUpLoaiChiPhi.Properties.ValueMember = "HAM_LUONG";

            }
            else
            if (cbLoaiChiPhi.SelectedIndex == 1)
            {

                this.searchLookUpEditView.Columns.AddRange (new DevExpress.XtraGrid.Columns.GridColumn[] {
                this.MaDVKT,
                this.TenDVKT,
                this.gridCDonGia});
                this.MaDVKT.Visible = true;
                this.MaDVKT.VisibleIndex = 0;
                this.MaDVKT.Width = 40;
                this.TenDVKT.Visible = true;
                this.TenDVKT.VisibleIndex = 1;
                this.TenDVKT.Width = 160;
                this.gridCDonGia.Visible = true;
                this.gridCDonGia.VisibleIndex = 2;
                this.gridCDonGia.Width = 50;


                lookUpLoaiChiPhi.Properties.DataSource = dataDVKT;
                lookUpLoaiChiPhi.Properties.DisplayMember = "TEN_DVKT";
                //lookUpLoaiChiPhi.Properties.ValueMember = "TEN_DVKT";
            }
            else
            {
                this.searchLookUpEditView.Columns.AddRange (new DevExpress.XtraGrid.Columns.GridColumn[] {
                this.MaVTYT,
                this.TenVTYT,
                this.gridCDonGia,
                this.TenBV});
                this.MaVTYT.Visible = true;
                this.MaVTYT.VisibleIndex = 0;
                this.MaVTYT.Width = 40;
                this.TenVTYT.Visible = true;
                this.TenVTYT.VisibleIndex = 1;
                this.TenVTYT.Width = 160;
                this.gridCDonGia.Visible = true;
                this.gridCDonGia.VisibleIndex = 2;
                this.gridCDonGia.Width = 40;
                this.TenBV.Visible = true;
                this.TenBV.VisibleIndex = 3;
                this.TenBV.Width = 160;

                lookUpLoaiChiPhi.Properties.DataSource = dataVTYT;
                lookUpLoaiChiPhi.Properties.DisplayMember = "TEN_VTYT";
                //lookUpLoaiChiPhi.Properties.ValueMember = "TEN_VTYT";
            }
        }

        private void btnOK_Click (object sender, EventArgs e)
        {
            this.Close ();
        }

        private void lookUpLoaiChiPhi_EditValueChanged (object sender, EventArgs e)
        {
           
        }

        private void btnChon_Click (object sender, EventArgs e)
        {
            if(cbLoaiChiPhi.SelectedIndex == 0)
            {
                try
                {
                    string maDichVu = (lookUpLoaiChiPhi.GetSelectedDataRow () as DataRowView)[0].ToString ();
                    string tenDV = (lookUpLoaiChiPhi.GetSelectedDataRow () as DataRowView)[1].ToString ();
                    foreach (DataRowView dr in (gridControlThuoc.DataSource as DataView))
                    {
                        if (dr["MA_THUOC"].ToString () == maDichVu && dr["TEN_THUOC"].ToString() == tenDV)
                        {
                            MessageBox.Show ("Thuốc đã chọn, nhập lại số lượng!");
                            return;
                        }
                    }
                    DataRowView drNew = (gridControlThuoc.DataSource as DataView).AddNew ();
                    drNew["MA_THUOC"] = (lookUpLoaiChiPhi.GetSelectedDataRow () as DataRowView)[0].ToString ();
                    drNew["TEN_THUOC"] = (lookUpLoaiChiPhi.GetSelectedDataRow () as DataRowView)[1].ToString ();
                    drNew["DON_GIA"] = (lookUpLoaiChiPhi.GetSelectedDataRow () as DataRowView)[8].ToString ();
                    drNew["DON_VI_TINH"] = (lookUpLoaiChiPhi.GetSelectedDataRow () as DataRowView)[7].ToString ();
                    drNew["HAM_LUONG"] = (lookUpLoaiChiPhi.GetSelectedDataRow () as DataRowView)[3].ToString ();
                    drNew["DUONG_DUNG"] = (lookUpLoaiChiPhi.GetSelectedDataRow () as DataRowView)[4].ToString ();
                    drNew["SO_DANG_KY"] = (lookUpLoaiChiPhi.GetSelectedDataRow () as DataRowView)[9].ToString ();
                    drNew["NHOM"] = (lookUpLoaiChiPhi.GetSelectedDataRow () as DataRowView)[15].ToString ();
                    drNew["MA_KHOA"] = (lookUpMaKhoa.GetSelectedDataRow () as DataRowView)[0].ToString ();
                    drNew["MA_BAC_SI"] = (lookUpMaBS.GetSelectedDataRow () as DataRowView)[0].ToString ();
                    drNew["NGAY_YL"] = dateNgayYLenh.Text;
                    drNew["SO_LUONG"] = txtSoLuong.Value;
                    drNew["TYLE_TT"] = 100;
                    drNew["THANH_TIEN"] = txtSoLuong.Value * Convert.ToDecimal (drNew["DON_GIA"]);

                    lookUpLoaiChiPhi.Focus ();
                    txtSoLuong.ResetText ();
                }
                catch (Exception ex)
                {
                    MessageBox.Show (ex.Message);
                }
            }
            else
            if(cbLoaiChiPhi.SelectedIndex == 1)
            {
                try
                {
                    string maDichVu = (lookUpLoaiChiPhi.GetSelectedDataRow () as DataRowView)[1].ToString ();
                    string tenDV = (lookUpLoaiChiPhi.GetSelectedDataRow () as DataRowView)[2].ToString ();
                    foreach (DataRowView dr in (gridControlDVKT.DataSource as DataView))
                    {
                        if (dr["MA_DICH_VU"].ToString () == maDichVu && dr["TEN_DICH_VU"].ToString() == tenDV)
                        {
                            MessageBox.Show ("Dịch vụ đã chọn, nhập lại số lượng!");
                            return;
                        }
                    }
                    DataRowView drNew = (gridControlDVKT.DataSource as DataView).AddNew ();
                    drNew["MA_DICH_VU"] = (lookUpLoaiChiPhi.GetSelectedDataRow () as DataRowView)[1].ToString ();
                    drNew["TEN_DICH_VU"] = (lookUpLoaiChiPhi.GetSelectedDataRow () as DataRowView)[2].ToString ();
                    drNew["DON_GIA"] = (lookUpLoaiChiPhi.GetSelectedDataRow () as DataRowView)[4].ToString ();
                    drNew["DON_VI_TINH"] = (lookUpLoaiChiPhi.GetSelectedDataRow () as DataRowView)[8].ToString ();
                    drNew["MA_NHOM"] = (lookUpLoaiChiPhi.GetSelectedDataRow () as DataRowView)[0].ToString ();
                    drNew["MA_KHOA"] = (lookUpMaKhoa.GetSelectedDataRow () as DataRowView)[0].ToString ();
                    drNew["MA_BAC_SI"] = (lookUpMaBS.GetSelectedDataRow () as DataRowView)[0].ToString ();
                    drNew["NGAY_YL"] = dateNgayYLenh.Text;
                    drNew["SO_LUONG"] = txtSoLuong.Value;
                    drNew["TYLE_TT"] = 100;
                    drNew["THANH_TIEN"] = txtSoLuong.Value * Convert.ToDecimal (drNew["DON_GIA"]);


                    lookUpLoaiChiPhi.Focus ();
                    txtSoLuong.ResetText ();
                }
                catch (Exception ex)
                {
                    MessageBox.Show (ex.Message);
                }
            }
            else
            {
                try
                {
                    string maDichVu = (lookUpLoaiChiPhi.GetSelectedDataRow () as DataRowView)[0].ToString ();
                    string tenDV = (lookUpLoaiChiPhi.GetSelectedDataRow () as DataRowView)[2].ToString ();
                    foreach (DataRowView dr in (gridControlVTYT.DataSource as DataView))
                    {
                        if (dr["MA_DICH_VU"].ToString () == maDichVu && dr["TEN_DICH_VU"].ToString () == tenDV)
                        {
                            MessageBox.Show ("Vật tư đã chọn, nhập lại số lượng!");
                            return;
                        }
                    }
                    DataRowView drNew = (gridControlVTYT.DataSource as DataView).AddNew ();
                    drNew["MA_DICH_VU"] = (lookUpLoaiChiPhi.GetSelectedDataRow () as DataRowView)[0].ToString ();
                    drNew["TEN_DICH_VU"] = (lookUpLoaiChiPhi.GetSelectedDataRow () as DataRowView)[2].ToString ();
                    drNew["DON_GIA"] = (lookUpLoaiChiPhi.GetSelectedDataRow () as DataRowView)[3].ToString ();
                    drNew["DON_VI_TINH"] = (lookUpLoaiChiPhi.GetSelectedDataRow () as DataRowView)[4].ToString ();
                    drNew["MA_NHOM"] = (lookUpLoaiChiPhi.GetSelectedDataRow () as DataRowView)[7].ToString ();
                    drNew["MA_KHOA"] = (lookUpMaKhoa.GetSelectedDataRow () as DataRowView)[0].ToString ();
                    drNew["MA_BAC_SI"] = (lookUpMaBS.GetSelectedDataRow () as DataRowView)[0].ToString ();
                    drNew["NGAY_YL"] = dateNgayYLenh.Text;
                    drNew["SO_LUONG"] = txtSoLuong.Value;
                    drNew["TYLE_TT"] = 100;
                    drNew["THANH_TIEN"] = txtSoLuong.Value * Convert.ToDecimal (drNew["DON_GIA"]);


                    lookUpLoaiChiPhi.Focus ();
                    txtSoLuong.ResetText ();
                }
                catch (Exception ex)
                {
                    MessageBox.Show (ex.Message);
                }
            }
        }

        private void btnXoaThuoc_ButtonClick (object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            (gridControlThuoc.DataSource as DataView).Delete (gridViewThuoc.GetFocusedDataSourceRowIndex ());
        }

        private void btnXoaDVKT_ButtonClick (object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            (gridControlDVKT.DataSource as DataView).Delete (gridViewDVKT.GetFocusedDataSourceRowIndex ());
        }

        private void gridViewThuoc_RowUpdated (object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            int index = gridViewThuoc.GetFocusedDataSourceRowIndex ();
            try
            {
                int soluong = int.Parse ((gridControlThuoc.DataSource as DataView)[index]["SO_LUONG"].ToString ());
                int dongia = int.Parse ((gridControlThuoc.DataSource as DataView)[index]["DON_GIA"].ToString ());
                (gridControlThuoc.DataSource as DataView)[index]["THANH_TIEN"] = soluong * dongia;
            }
            catch { }
        }

        private void gridViewDVKT_RowUpdated (object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            int index = gridViewDVKT.GetFocusedDataSourceRowIndex ();
            try
            {
                int soluong = int.Parse ((gridControlDVKT.DataSource as DataView)[index]["SO_LUONG"].ToString ());
                int dongia = int.Parse ((gridControlDVKT.DataSource as DataView)[index]["DON_GIA"].ToString ());
                (gridControlDVKT.DataSource as DataView)[index]["THANH_TIEN"] = soluong * dongia;
            }
            catch { }
        }

        private void FrmThuocDVKT_FormClosing (object sender, FormClosingEventArgs e)
        {
            FrmNgoaiNoiTru.dvTienDVKT = (gridControlDVKT.DataSource as DataView);
            FrmNgoaiNoiTru.dvTienThuoc = (gridControlThuoc.DataSource as DataView);
            FrmNgoaiNoiTru.dvTienVTYT = (gridControlVTYT.DataSource as DataView);
        }

        private void lookUpLoaiChiPhi_KeyPress (object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtSoLuong.Focus ();
            }
        }


        private void txtSoLuong_KeyPress (object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnChon.Focus ();
            }
        }

        private void txtSoLuong_ValueChanged (object sender, EventArgs e)
        {
            if(txtSoLuong.Value >= 150)
            {
                MessageBox.Show ("Số lượng thuốc lớn hơn 150!!!","Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void gridViewVTYT_RowUpdated (object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            int index = gridViewVTYT.GetFocusedDataSourceRowIndex ();
            try
            {
                int soluong = int.Parse ((gridViewVTYT.DataSource as DataView)[index]["SO_LUONG"].ToString ());
                int dongia = int.Parse ((gridViewVTYT.DataSource as DataView)[index]["DON_GIA"].ToString ());
                (gridViewVTYT.DataSource as DataView)[index]["THANH_TIEN"] = soluong * dongia;
            }
            catch { }
        }

        private void btnXoaVTYT_ButtonClick (object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            (gridControlVTYT.DataSource as DataView).Delete (gridViewVTYT.GetFocusedDataSourceRowIndex ());
        }

        public FrmThuocDVKT (Connection db)
        {
            InitializeComponent ();
            thuoc = new ThuocDAO (db);
            dataDVKT = new DataTable ();
            dataThuoc = new DataTable ();
            dataVTYT = new DataTable ();
            searchLookUpEditView.Appearance.FocusedRow.BackColor = Color.FromArgb(128, 255, 128);
            searchLookUpEditView.Appearance.FocusedRow.Options.UseBackColor = true;
            searchLookUpEditView.Appearance.SelectedRow.BackColor = Color.FromArgb (128, 255, 128);
            searchLookUpEditView.Appearance.SelectedRow.Options.UseBackColor = true;
        }
        private void FrmThuocDVKT_Load (object sender, EventArgs e)
        {
            dataThuoc = thuoc.DSThuoc ();
            dataDVKT = thuoc.DSDVKT ();
            dataVTYT = thuoc.DSVTYT ();
            cbLoaiChiPhi.SelectedIndex = 0;

            lookUpMaKhoa.Properties.DataSource = thuoc.DSKhoa ();
            lookUpMaKhoa.Properties.DisplayMember = "TEN_KHOA";
            lookUpMaKhoa.Properties.ValueMember = "MA_KHOA";
            lookUpMaKhoa.ItemIndex = MaKhoa;

            lookUpMaBS.Properties.DataSource = thuoc.DSNhanVien ();
            lookUpMaBS.Properties.DisplayMember = "TEN_NHANVIEN";
            lookUpMaBS.Properties.ValueMember = "MA_NHANVIEN";
            lookUpMaBS.ItemIndex = MaBS;


            gridControlThuoc.DataSource = FrmNgoaiNoiTru.dvTienThuoc;
            gridControlDVKT.DataSource = FrmNgoaiNoiTru.dvTienDVKT;
            gridControlVTYT.DataSource = FrmNgoaiNoiTru.dvTienVTYT;

            dateNgayYLenh.Text =DateTime.ParseExact (DateYLenh, "dd/MM/yyyy HH:mm", System.Globalization.CultureInfo.InvariantCulture).ToString();

            txtSoLuong.ResetText ();
            this.ActiveControl = lookUpLoaiChiPhi;
            
        }
    }
}
