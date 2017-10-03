using BHYT.DAO;
using BHYT.VO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BHYT
{
    public partial class FrmKCB : Form
    {
        KCBDAO kcb;
        BackgroundWorker bw = new BackgroundWorker();
        DataTable data;
        public FrmKCB (Connection db)
        {
            InitializeComponent ();
            kcb = new KCBDAO (db);
            bw.WorkerSupportsCancellation = true;
            bw.WorkerReportsProgress = true;
            bw.DoWork += new DoWorkEventHandler(bw_DoWork);
            bw.ProgressChanged += new ProgressChangedEventHandler(bw_ProgressChanged);
            bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_RunWorkerCompleted);
        }

        private void FrmKCB_Load (object sender, EventArgs e)
        {
            gridControl.DataSource = kcb.DSKCB ();
        }

        private void bntNhapExcel_Click (object sender, EventArgs e)
        {
            DialogResult dr = ImportExcel.openDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    data = ImportExcel.OpenFile();
                    if (bw.IsBusy != true)
                    {
                        bntNhapExcel.Enabled = false;
                        bw.RunWorkerAsync();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    return;
                }
                
            }
        }
        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lblTienTrinh.Text = "Hoàn thành";
            bntNhapExcel.Enabled = true;
            gridControl.DataSource = kcb.DSKCB();
        }
        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                KCBVO b;
                string err;
                int len = data.Rows.Count-1;
                int i = 0;
                foreach (DataRow dtRow in data.Rows)
                {
                    b = new KCBVO();
                    b.Ma = dtRow.ItemArray[1].ToString();
                    b.Ten = dtRow.ItemArray[2].ToString();
                    b.DiaChi = dtRow.ItemArray[5].ToString();
                    err = "";
                    if (b.Ma.Length > 0)
                    {
                        kcb.ThemCoSoKCB(ref err, b);
                    }
                    i++;
                    bw.ReportProgress((int)(100.0 / len * i));
                }
            }
            catch (Exception ex)
            {
                bw.CancelAsync();
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        private void bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            lblTienTrinh.Text = "Tiến trình: " + e.ProgressPercentage + "%";
            progressBarControl.Position = (e.ProgressPercentage);
        }
    }
}
