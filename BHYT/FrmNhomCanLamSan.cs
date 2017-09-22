using BHYT.DAO;
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
    public partial class FrmNhomCanLamSan : Form
    {
        CanLamSanDAO canlamsan;
        bool them = false;
        public FrmNhomCanLamSan(Connection db)
        {
            InitializeComponent();
            canlamsan = new CanLamSanDAO(db);
        }

        private void FrmNhomCanLamSan_Load(object sender, EventArgs e)
        {
            DataTable data = canlamsan.DSNhomDVKT();
            cbNhom.DataSource = data;
            cbNhom.DisplayMember = "TEN_NHOM";
            cbNhom.ValueMember = "MA_NHOM";
            //
            repositoryItemLookUpEdit.DataSource = data;
            repositoryItemLookUpEdit.DisplayMember = "TEN_NHOM";
            repositoryItemLookUpEdit.ValueMember = "MA_NHOM";

            LoadData();

            this.ActiveControl = txtMaNhom;
            them = true;

            
        }
        private void LoadData()
        {
            them = false;
            gridControl.DataSource = canlamsan.DSNhomCanLamSan();
        }
        private void btnMoi_Click(object sender, EventArgs e)
        {
            them = true;
            txtMaNhom.ReadOnly = false;
            txtMaNhom.Text = "";
            txtTenNhom.Text = "";
            txtPhong.Text = "";
            txtMauSo.Text = "";
            txtMaNhom.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(txtMaNhom.Text.Length==0)
            {
                txtMaNhom.Focus();
                MessageBox.Show("Vui lòng nhập mã nhóm!", "Lỗi");
                return;
            }
            if (txtTenNhom.Text.Length == 0)
            {
                txtTenNhom.Focus();
                MessageBox.Show("Vui lòng nhập tên nhóm!", "Lỗi");
                return;
            }
            canlamsan.MaNhom = txtMaNhom.Text;
            canlamsan.TenNhom = txtTenNhom.Text;
            canlamsan.Phong = txtPhong.Text;
            canlamsan.Nhom = cbNhom.SelectedValue.ToString();
            canlamsan.MauSo = txtMauSo.Text;
            string err = "";
            if(them)
            {
                canlamsan.NhomCanLamSan(ref err, "INSERT");
            }
            else
            {
                canlamsan.NhomCanLamSan(ref err, "UPDATE");
            }
            if(!string.IsNullOrEmpty(err))
            {
                MessageBox.Show(err, "Lỗi");
                return;
            }
            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            string err = "";
            // Hiện hộp thoại hỏi đáp 
            traloi = MessageBox.Show("Chắc chắn bạn muốn xóa nhóm này?", "Trả lời",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
            {
                if (!canlamsan.NhomCanLamSan(ref err,"DELETE"))
                {
                    MessageBox.Show(err,"Lỗi");
                    return;
                }
                LoadData();
            }
        }

        private void gridView_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            DataRow dr = gridView.GetDataRow(e.RowHandle);
            if(dr!=null)
            {
                them = false;
                txtMaNhom.Text = dr["MaNhom"].ToString();
                canlamsan.MaNhom = txtMaNhom.Text;
                txtTenNhom.Text = dr["TenNhom"].ToString();
                txtPhong.Text = dr["Phong"].ToString();
                cbNhom.SelectedValue = dr["NhomChinh"];
                txtMauSo.Text = dr["MauSo"].ToString();
            }
        }
    }
}
