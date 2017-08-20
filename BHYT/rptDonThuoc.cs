using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace BHYT
{
    public partial class rptDonThuoc : DevExpress.XtraReports.UI.XtraReport
    {
        public rptDonThuoc ()
        {
            SplashScreen.Start ();
            InitializeComponent ();
        }

        private void rptDonThuoc_ParametersRequestBeforeShow (object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
            SplashScreen.Stop ();
        }
    }
}
