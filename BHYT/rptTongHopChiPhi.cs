using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Windows.Forms;
using System.Threading;

namespace BHYT
{
    public partial class rptTongHopChiPhi : DevExpress.XtraReports.UI.XtraReport
    {
        public rptTongHopChiPhi ()
        {
            InitializeComponent ();
        }

        private void rptTongHopChiPhi_ParametersRequestBeforeShow (object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
            SplashScreen.Stop ();
        }
    }
}
