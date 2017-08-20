using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace BHYT
{
    public partial class rptThongKeSoLuong : DevExpress.XtraReports.UI.XtraReport
    {
        public rptThongKeSoLuong ()
        {
            SplashScreen.Start ();
            InitializeComponent ();
        }

        private void rptThongKeSoLuong_ParametersRequestBeforeShow (object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
            SplashScreen.Stop ();
        }
    }
}
