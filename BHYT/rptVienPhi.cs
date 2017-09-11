using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace BHYT
{
    public partial class rptVienPhi : DevExpress.XtraReports.UI.XtraReport
    {
        public rptVienPhi()
        {
            SplashScreen.Start();
            InitializeComponent();
        }

        private void rptVienPhi_ParametersRequestBeforeShow(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
            SplashScreen.Stop();
        }
    }
}
