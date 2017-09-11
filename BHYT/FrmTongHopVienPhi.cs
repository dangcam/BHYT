using BHYT.DAO;
using DevExpress.XtraReports.UI;
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
    public partial class FrmTongHopVienPhi : Form
    {
        ThongKeDAO thongke;
        public FrmTongHopVienPhi(Connection db)
        {
            InitializeComponent();
            thongke = new ThongKeDAO(db);
        }

        private void FrmTongHopVienPhi_Load(object sender, EventArgs e)
        {
            dateTuNgay.Value = DateTime.Now;
            dateDenNgay.Value = DateTime.Now;
            cbLoaiKCB.SelectedIndex = 0;
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            string ngayBD = DateTime.ParseExact(dateTuNgay.Text.ToString(), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture).ToString("yyyyMMdd");
            string ngayKT = DateTime.ParseExact(dateDenNgay.Text.ToString(), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture).ToString("yyyyMMdd");
            DataTable data = thongke.DSVienPhi(cbLoaiKCB.SelectedIndex, ngayBD, ngayKT);
            if (data != null)
            {
                rptVienPhi rpt = new rptVienPhi();
                int tong = 0;
                int dem = 0;
                bool[] EnableCell = new bool[16];
                for(int i=1;i<16;i++)
                {
                    tong = Utils.ToInt(data.Compute("SUM(["+i+"])","").ToString());
                    if(tong>0)
                    {
                        dem++;
                        EnableCell[i] = true;
                    }
                    else
                    {
                        EnableCell[i] = false;
                    }
                }
                rpt.DataSource = data;

                rpt.CreateDocument();
                rpt.ShowPreviewDialog();
            }
        }
        
    }
}
