using BHYT.DAO;
using BHYT.VO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BHYT
{
    public partial class FrmBenhICD : Form
    {
        BenhDAO benh = null;
        public FrmBenhICD (Connection db)
        {
            InitializeComponent ();
            benh = new BenhDAO (db);
        }

        private void LoadData ()
        {
            gridControl.DataSource = benh.DSBenh ();
        }

        private void FrmBenhICD_Load (object sender, EventArgs e)
        {
            LoadData ();
        }

        private void bntNhapExcel_Click (object sender, EventArgs e)
        {
            DialogResult dr = ImportExcel.openDialog ();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    DataTable data = ImportExcel.OpenFile ();
                    BenhVO b = null;
                    foreach (DataRow dtRow in data.Rows)
                    {
                        b = new BenhVO ();
                        b.MaBenh = dtRow.ItemArray[0].ToString ();
                        b.TenBenh = dtRow.ItemArray[1].ToString ();
                        b.MaLoai = dtRow.ItemArray[2].ToString ();
                        b.MaNhom = dtRow.ItemArray[3].ToString ();
                        string err = "";
                        benh.ThemBenh (ref err, b);
                    }
                    LoadData ();
                }
                catch (Exception ex)
                {
                    MessageBox.Show (ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
        }
    }
}
