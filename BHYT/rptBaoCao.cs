using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace BHYT
{
    public partial class rptBaoCao : DevExpress.XtraReports.UI.XtraReport
    {
        public rptBaoCao()
        {
            InitializeComponent();
        }

        private void rptBaoCao_ParametersRequestBeforeShow(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
            SplashScreen.Stop();
        }
    }
}
