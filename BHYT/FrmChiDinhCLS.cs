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
    public partial class FrmChiDinhCLS : Form
    {
        CanLamSanDAO canlamsan;
        public string MaLienKet { get; set; }
        public string HoTen { get; set; }
        public FrmChiDinhCLS(Connection db)
        {
            InitializeComponent();
            canlamsan = new CanLamSanDAO(db);
        }

        private void FrmChiDinhCLS_Load(object sender, EventArgs e)
        {
            txtHoTen.Text = HoTen;
            gridControl.DataSource = canlamsan.DSChiDinhCanLamSan(MaLienKet);
        }

        private void btnIn_Click(object sender, EventArgs e)
        {

        }
    }
}
