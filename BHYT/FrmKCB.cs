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
        public FrmKCB (Connection db)
        {
            InitializeComponent ();
            kcb = new KCBDAO (db);
        }

        private void FrmKCB_Load (object sender, EventArgs e)
        {
            gridControl.DataSource = kcb.DSKCB ();
        }

        private void bntNhapExcel_Click (object sender, EventArgs e)
        {
            DialogResult dr = ImportExcel.openDialog ();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    DataTable data = ImportExcel.OpenFile ();
                    KCBVO b = null;
                    foreach (DataRow dtRow in data.Rows)
                    {
                        b = new KCBVO ();
                        b.Ma= dtRow.ItemArray[0].ToString ();
                        b.Ten = dtRow.ItemArray[1].ToString ();
                        b.DiaChi = dtRow.ItemArray[2].ToString ();
                        string err = "";
                        kcb.ThemCoSoKCB (ref err, b);
                    }
                    gridControl.DataSource = kcb.DSKCB ();
                }
                catch (Exception ex)
                {
                    MessageBox.Show (ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
        }
    }
}
