using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BHYT
{
    public partial class FrmLoad : Form
    {
        Timer timer = new Timer ();
        int count = 0;
        public FrmLoad ()
        {
            InitializeComponent ();
            timer.Tick += new EventHandler (TimerEventProcessor);
            timer.Interval = 100;
            timer.Start ();
        }
        private void TimerEventProcessor (object sender, EventArgs e)
        {
            count++;
            if(count > 100)
            {
                timer.Stop ();
                this.Close ();
            }
        }
    }
}
