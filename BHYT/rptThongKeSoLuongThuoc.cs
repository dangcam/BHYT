using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace BHYT
{
    public partial class rptThongKeSoLuongThuoc : DevExpress.XtraReports.UI.XtraReport
    {
        public rptThongKeSoLuongThuoc()
        {
            InitializeComponent();
        }

        private void rptThongKeSoLuongThuoc_ParametersRequestBeforeShow(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
            SplashScreen.Stop();
        }
    }
}
