﻿using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace BHYT
{
    public partial class rptChiPhi : DevExpress.XtraReports.UI.XtraReport
    {
        public rptChiPhi ()
        {
            SplashScreen.Start ();
            InitializeComponent ();
        }

        private void rptChiPhi_ParametersRequestBeforeShow (object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
            SplashScreen.Stop ();
        }
    }
}
