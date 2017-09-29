using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace BHYT.MauSo
{
    public partial class rptPhieuYeuCau : DevExpress.XtraReports.UI.XtraReport
    {
        public rptPhieuYeuCau()
        {
            SplashScreen.Start();
            InitializeComponent();
        }

        private void rptPhieuYeuCau_ParametersRequestBeforeShow(object sender, 
            DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
            SplashScreen.Stop();
        }
    }
}
