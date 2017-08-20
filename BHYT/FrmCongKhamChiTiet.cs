using BHYT.DAO;
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
    public partial class FrmCongKhamChiTiet : Form
    {
        TienKhamDAO tienkham;
        public FrmCongKhamChiTiet (Connection db)
        {
            InitializeComponent ();
            tienkham = new TienKhamDAO (db);
        }
        private void LoadDadata()
        {
            string maCongKham = string.Empty;
            for(int i=0;i<FrmNgoaiNoiTru.dvCongKham.Count;i++)
            {
                maCongKham += "," + FrmNgoaiNoiTru.dvCongKham[i]["MA_DICH_VU"];
            }
            DataTable data = tienkham.DSCongKham ();
            data.Columns.Add ("CHON", typeof (bool));
            for(int i = 0;i< data.Rows.Count;i++)
            {
                if(maCongKham.Contains(data.Rows[i]["MA_DICH_VU"].ToString()))
                {
                    data.Rows[i]["CHON"] = true;
                }
                else
                {
                    data.Rows[i]["CHON"] = false;
                }
            }
            gridControl.DataSource = data;
            //gridView.Appearance.FocusedRow.BorderColor
        }
        private void FrmCongKhamChiTiet_Load (object sender, EventArgs e)
        {
            LoadDadata ();
            this.ActiveControl = gridControl;
        }

        private void FrmCongKhamChiTiet_FormClosing (object sender, FormClosingEventArgs e)
        {
            DataView dv = (gridControl.DataSource as DataTable).AsEnumerable ().Where (r => r.Field<bool> ("CHON") == true).AsDataView ();
            FrmNgoaiNoiTru.dvCongKham = dv;
        }

        private void btnOK_Click (object sender, EventArgs e)
        {
            this.Close ();
        }

        private void gridView_KeyPress (object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                (gridView.GetFocusedDataRow() as DataRow)["CHON"] = !bool.Parse((gridView.GetFocusedDataRow() as DataRow)["CHON"].ToString ());
            }
            btnOK.Focus ();
        }

        private void gridView_DoubleClick (object sender, EventArgs e)
        {
            (gridView.GetFocusedDataRow () as DataRow)["CHON"] = !bool.Parse ((gridView.GetFocusedDataRow () as DataRow)["CHON"].ToString ());
        }
    }
}
