﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace BHYT
{
    public class SplashScreen
    {
        private static Thread thread = null;
        public static void Start ()
        {
            if(thread != null)
            {
                Stop ();
            }
            thread = new Thread (new ThreadStart (LoadSflash));
            thread.Start ();
        }
        private static void LoadSflash ()
        {
            try
            {
                Application.Run (new FrmLoad ());
            }
            catch (ThreadAbortException e) {
                Thread.ResetAbort();
            }
        }
        public static void Stop()
        {
            if(thread!=null)
            {
                thread.Abort ();
            }
        }
    }
}
