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
    public partial class FrmThongTinChiTiet : Form
    {
        public FrmThongTinChiTiet()
        {
            InitializeComponent();
        }
        public string XML2 = "";
        public string XML3 = "";
        private void FrmThongTinChiTiet_Load(object sender, EventArgs e)
        {
            gridControlXML2.DataSource = null;
            gridControlXML3.DataSource = null;
            DataTable dataxml2 = new DataTable();
            dataxml2.Columns.Add("Stt",typeof(string));
            dataxml2.Columns.Add("MaThuoc", typeof(string));
            dataxml2.Columns.Add("TenThuoc", typeof(string));
            dataxml2.Columns.Add("HamLuong", typeof(string));
            dataxml2.Columns.Add("DonViTinh", typeof(string));
            dataxml2.Columns.Add("SoLuong", typeof(string));
            dataxml2.Columns.Add("DonGia", typeof(string));
            dataxml2.Columns.Add("ThanhTien", typeof(string));
            dataxml2.Columns.Add("LieuDung", typeof(string));
            string[] xml2 = XML2.Replace("\"","").Split('{');
           foreach(string thuoc in xml2)
            {
                if (thuoc.Length > 0)
                {
                    DataRow dr = dataxml2.NewRow();
                    string[] ds = thuoc.Split(',');
                    foreach (string column in ds)
                    {
                        if (dr.Table.Columns.Contains(column.Split(':')[0]))
                        {
                            dr[column.Split(':')[0]] = column.Split(':')[1];
                        }
                    }
                    dataxml2.Rows.Add(dr);
                }
            }
            gridControlXML2.DataSource = dataxml2;
            //
            DataTable dataxml3 = new DataTable();
            dataxml3.Columns.Add("Stt", typeof(string));
            dataxml3.Columns.Add("MaDichVu", typeof(string));
            dataxml3.Columns.Add("TenDichVu", typeof(string));
            dataxml3.Columns.Add("DonViTinh", typeof(string));
            dataxml3.Columns.Add("SoLuong", typeof(string));
            dataxml3.Columns.Add("DonGia", typeof(string));
            dataxml3.Columns.Add("ThanhTien", typeof(string));
            string[] xml3 = XML3.Replace("\"", "").Split('{');
            foreach (string dvkt in xml3)
            {
                if (dvkt.Length > 0)
                {
                    DataRow dr = dataxml3.NewRow();
                    string[] ds = dvkt.Split(',');
                    foreach (string column in ds)
                    {
                        if (dr.Table.Columns.Contains(column.Split(':')[0]))
                        {
                            dr[column.Split(':')[0]] = column.Split(':')[1];
                        }
                    }
                    dataxml3.Rows.Add(dr);
                }
            }
            gridControlXML3.DataSource = dataxml3;
        }
    }
}
