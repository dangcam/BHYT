using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace BHYT
{
    public partial class rptThongKeBNTT : DevExpress.XtraReports.UI.XtraReport
    {
        public rptThongKeBNTT ()
        {
            SplashScreen.Start ();
            InitializeComponent ();
        }

        private void rptThongKeBNTT_ParametersRequestBeforeShow (object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
            SplashScreen.Stop ();
        }
    }
}
