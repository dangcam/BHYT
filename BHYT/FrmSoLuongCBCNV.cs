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
    public partial class FrmSoLuongCBCNV : Form
    {
        SoLuongDAO soLuongDAO;
        public FrmSoLuongCBCNV()
        {
            InitializeComponent();
            soLuongDAO = new SoLuongDAO();
        }

        private void FrmSoLuongCBCNV_Load(object sender, EventArgs e)
        {
            for(int nam = DateTime.Now.Year-5;nam<DateTime.Now.Year+5;nam++)
            {
                cbNam.Items.Add(nam);
            }
            cbNam.SelectedIndex = 5;
        }

        private void cbNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            int nam = Utils.ToInt(cbNam.SelectedItem.ToString(),DateTime.Now.Year);
            DataTable data = soLuongDAO.DSSoLuong(nam);
            if(data!=null && data.Rows.Count>0)
            {
                btnThem.Enabled = false;
                btnLuu.Enabled = true;
            }
            else
            {
                btnThem.Enabled = true;
                btnLuu.Enabled = false;
            }
            gridControl.DataSource = data;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string err = "";
            int nam = Utils.ToInt(cbNam.SelectedItem.ToString(), DateTime.Now.Year);
            DataTable data = soLuongDAO.DSDonVi();
            if (data != null && data.Rows.Count > 0)
            {
                foreach (DataRow dr in data.Rows)
                    soLuongDAO.SpSoLuong(ref err, "INSERT", nam, dr["MADV"].ToString(), 1);
                gridControl.DataSource = soLuongDAO.DSSoLuong(nam);
                btnThem.Enabled = false;
                btnLuu.Enabled = true;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int nam = Utils.ToInt(cbNam.SelectedItem.ToString(), DateTime.Now.Year);
            string err = "";
            DataTable data = (gridControl.DataSource as DataTable);
            foreach (DataRow dr in data.Rows)
                soLuongDAO.SpSoLuong(ref err, "UPDATE", nam, dr["MADV"].ToString(), Utils.ToInt(dr["SOLUONG"].ToString()));
        }
    }
}
