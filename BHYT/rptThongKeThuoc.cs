using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace BHYT
{
    public partial class rptThongKeThuoc : DevExpress.XtraReports.UI.XtraReport
    {
        public rptThongKeThuoc ()
        {
            SplashScreen.Start ();
            InitializeComponent ();
        }

        private void rptThongKeThuoc_ParametersRequestBeforeShow (object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
            SplashScreen.Stop ();
        }
    }
}
