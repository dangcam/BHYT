using System;
using System.IO;
using System.Windows.Forms;

namespace BHYT
{
    public partial class FrmMain : Form
    {
        #region config

        public Connection db = null;

        ReadConfig readConfig;
        
        FrmDSCanLamSan frmCanLamSan;
        FrmNgoaiNoiTru frmNgoaiTru;
        FrmNhanVien frmNhanVien;
        FrmDSTiepNhan frmDSTiepNhan;
        FrmBenhICD frmBenh;
        FrmKhamBHYT frmKhamBHYT;
        FrmTienGiuong frmTienGiuong;
        FrmCongKham frmTienKham;
        FrmDVKT frmDVKT;
        FrmThuoc frmThuoc;
        FrmKCB frmKCB;
        FrmVTYT frmVTYT;
        Form frmDN;
        #endregion

        public FrmMain (Form frm)
        {
            readConfig = new ReadConfig ();
            InitializeComponent ();
            this.WindowState = FormWindowState.Maximized;
            frmDN = frm;
            
        }

        private void FrmMain_Load (object sender, EventArgs e)
        {
            readConfig.Read ();
            db = new Connection ();
        }

        private void MenuItemNgoaiTru_Click (object sender, EventArgs e)
        {
            if (!this.panelMain.Controls.Contains (frmNgoaiTru))
            {
                frmNgoaiTru = new FrmNgoaiNoiTru (db);
                frmNgoaiTru.TopLevel = false;
                frmNgoaiTru.AutoScroll = true;
                this.panelMain.Controls.Add (frmNgoaiTru);
            }
            frmNgoaiTru.WindowState = FormWindowState.Maximized;
            frmNgoaiTru.Show ();
        }

        private void cauHinhToolStripMenuItem_Click (object sender, EventArgs e)
        {
            FrmCauHinh frmCauHinh = new FrmCauHinh ();
            frmCauHinh.ShowDialog ();
            db = new Connection ();
        }

        private void MenuItemNVYTBS_Click (object sender, EventArgs e)
        {
            if (!this.panelMain.Controls.Contains (frmNhanVien))
            {
                frmNhanVien = new FrmNhanVien (db);
                frmNhanVien.TopLevel = false;
                frmNhanVien.AutoScroll = true;
                this.panelMain.Controls.Add (frmNhanVien);
            }
            frmNhanVien.WindowState = FormWindowState.Normal;
            frmNhanVien.Show ();
        }

        private void benhICDToolStripMenuItem_Click (object sender, EventArgs e)
        {
            if (!this.panelMain.Controls.Contains (frmBenh))
            {
                frmBenh = new FrmBenhICD (db);
                frmBenh.TopLevel = false;
                frmBenh.AutoScroll = true;
                this.panelMain.Controls.Add (frmBenh);
            }
            frmBenh.WindowState = FormWindowState.Normal;
            frmBenh.StartPosition = FormStartPosition.CenterScreen;
            frmBenh.Show ();
        }

        private void tienGiuongToolStripMenuItem_Click (object sender, EventArgs e)
        {
            if (!this.panelMain.Controls.Contains (frmTienGiuong))
            {
                frmTienGiuong = new FrmTienGiuong (db);
                frmTienGiuong.TopLevel = false;
                frmTienGiuong.AutoScroll = true;
                frmTienGiuong.StartPosition = FormStartPosition.CenterScreen;
                this.panelMain.Controls.Add (frmTienGiuong);
            }
            frmTienGiuong.WindowState = FormWindowState.Normal;
            frmTienGiuong.Show ();
        }

        private void tienKhamToolStripMenuItem_Click (object sender, EventArgs e)
        {
            if (!this.panelMain.Controls.Contains (frmTienKham))
            {
                frmTienKham = new FrmCongKham (db);
                frmTienKham.TopLevel = false;
                frmTienKham.AutoScroll = true;
                frmTienKham.StartPosition = FormStartPosition.CenterScreen;
                this.panelMain.Controls.Add (frmTienKham);
            }
            frmTienKham.WindowState = FormWindowState.Normal;
            frmTienKham.Show ();
        }

        private void dToolStripMenuItem_Click (object sender, EventArgs e)
        {
            if (!this.panelMain.Controls.Contains (frmDVKT))
            {
                frmDVKT = new FrmDVKT (db);
                frmDVKT.TopLevel = false;
                frmDVKT.AutoScroll = true;
                frmDVKT.StartPosition = FormStartPosition.CenterScreen;
                this.panelMain.Controls.Add (frmDVKT);
            }
            frmDVKT.WindowState = FormWindowState.Normal;
            frmDVKT.Show ();
        }

        private void thuocToolStripMenuItem_Click (object sender, EventArgs e)
        {
            if (!this.panelMain.Controls.Contains (frmThuoc))
            {
                frmThuoc = new FrmThuoc (db);
                frmThuoc.TopLevel = false;
                frmThuoc.AutoScroll = true;
                frmThuoc.StartPosition = FormStartPosition.CenterScreen;
                this.panelMain.Controls.Add (frmThuoc);
            }
            frmThuoc.WindowState = FormWindowState.Normal;
            frmThuoc.Show ();
        }

        private void coSoKCBToolStripMenuItem_Click (object sender, EventArgs e)
        {
            if (!this.panelMain.Controls.Contains (frmKCB))
            {
                frmKCB = new FrmKCB (db);
                frmKCB.TopLevel = false;
                frmKCB.AutoScroll = true;
                frmKCB.StartPosition = FormStartPosition.CenterScreen;
                this.panelMain.Controls.Add (frmKCB);
            }
            frmKCB.WindowState = FormWindowState.Normal;
            frmKCB.Show ();
        }

        private void luongCoBanToolStripMenuItem_Click (object sender, EventArgs e)
        {
            FrmLuongCoBan frmLuong = new FrmLuongCoBan ();
            frmLuong.ShowDialog ();
        }

        private void phimTatToolStripMenuItem_Click (object sender, EventArgs e)
        {
            FrmPhimTat frm = new FrmPhimTat ();
            frm.ShowDialog ();
        }

        private void thoatToolStripMenuItem_Click (object sender, EventArgs e)
        {
            this.Close ();
        }

        private void thongKeSoLieuToolStripMenuItem_Click (object sender, EventArgs e)
        {
            FrmThongKeSoLieu frm = new FrmThongKeSoLieu (db);
            frm.ShowDialog ();
        }

        private void vtyttoolStripMenuItem_Click (object sender, EventArgs e)
        {           
            if (!this.panelMain.Controls.Contains (frmVTYT))
            {
                frmVTYT = new FrmVTYT (db);
                frmVTYT.TopLevel = false;
                frmVTYT.AutoScroll = true;
                frmVTYT.StartPosition = FormStartPosition.CenterScreen;
                this.panelMain.Controls.Add (frmVTYT);
            }
            frmVTYT.WindowState = FormWindowState.Normal;
            frmVTYT.Show ();

        }

        private void thongKeSoLuongToolStripMenuItem_Click (object sender, EventArgs e)
        {
            FrmThongKeSoLuong frm = new FrmThongKeSoLuong (db);
            frm.ShowDialog ();
        }

        private void kiemTraTheToolStripMenuItem_Click (object sender, EventArgs e)
        {
            FrmKiemTra frm = new FrmKiemTra ();
            frm.ShowDialog ();
        }

        private void FrmMain_FormClosing (object sender, FormClosingEventArgs e)
        {
            frmDN.Show ();
        }

        private void doiMatKhauToolStripMenuItem_Click (object sender, EventArgs e)
        {
            FrmMatKhau frm = new FrmMatKhau ();
            frm.ShowDialog ();
        }

        private void saoLuuToolStripMenuItem_Click (object sender, EventArgs e)
        {   
            string filePath = "D:\\BHYT\\";
            if (!Directory.Exists (filePath))
            {
                Directory.CreateDirectory (filePath);
            }
            string sqlRestore = "Use master ALTER DATABASE " + AppConfig.Database + " SET SINGLE_USER WITH ROLLBACK IMMEDIATE Restore Database [" + AppConfig.Database + "] from disk='" + filePath + "Data_BHXH.bak'";
            string sqlBackup = "BACKUP DATABASE[" + AppConfig.Database + "] TO DISK = '"+filePath+"Data_BHXH.bak'";
            DAO.DataBaseDAO data = new DAO.DataBaseDAO (db);
            try
            {
                string err = "";
                if (data.BackUpOrRestore (ref err, sqlBackup))
                {
                    MessageBox.Show ("Dữ liệu đã được sao lưu!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show ("Dữ liệu không được sao lưu, " + err, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show ("Có lỗi!", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void huongDanToolStripMenuItem_Click (object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start ("HuongDanSuDung.pdf");
            }
            catch { }
        }

        private void khamBHYTToolStripMenuItem_Click (object sender, EventArgs e)
        {
            if (!this.panelMain.Controls.Contains (frmKhamBHYT))
            {
                frmKhamBHYT = new FrmKhamBHYT (db);
                frmKhamBHYT.TopLevel = false;
                frmKhamBHYT.AutoScroll = true;
                frmKhamBHYT.StartPosition = FormStartPosition.CenterScreen;
                this.panelMain.Controls.Add (frmKhamBHYT);
            }
            frmKhamBHYT.WindowState = FormWindowState.Normal;
            frmKhamBHYT.Show ();
        }

        private void dSTiepNhanToolStripMenuItem_Click (object sender, EventArgs e)
        {
            if (!this.panelMain.Controls.Contains (frmDSTiepNhan))
            {
                frmDSTiepNhan = new FrmDSTiepNhan (db);
                frmDSTiepNhan.TopLevel = false;
                frmDSTiepNhan.AutoScroll = true;
                frmDSTiepNhan.StartPosition = FormStartPosition.CenterScreen;
                this.panelMain.Controls.Add (frmDSTiepNhan);
            }
            frmDSTiepNhan.WindowState = FormWindowState.Normal;
            frmDSTiepNhan.Show ();
        }

        private void canLamSanToolStripMenuItem_Click (object sender, EventArgs e)
        {
            FrmCanLamSan frmCanLamSan = new FrmCanLamSan (db);
            frmCanLamSan.ShowDialog ();
        }

        private void thongKeBNTTToolStripMenuItem_Click (object sender, EventArgs e)
        {
            FrmThongKeBNTT frmBNTT = new FrmThongKeBNTT (db);
            frmBNTT.ShowDialog ();
        }

        private void thongKeThuocToolStripMenuItem_Click (object sender, EventArgs e)
        {
            FrmThongKeThuoc frmThuoc = new FrmThongKeThuoc (db);
            frmThuoc.ShowDialog ();
        }

        private void tongHopVienPhiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTongHopVienPhi frmTongHop = new FrmTongHopVienPhi(db);
            frmTongHop.ShowDialog();
        }

        private void dsCanLamSanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.panelMain.Controls.Contains(frmCanLamSan))
            {
                frmCanLamSan = new FrmDSCanLamSan(db);
                frmCanLamSan.TopLevel = false;
                frmCanLamSan.AutoScroll = true;
                frmCanLamSan.StartPosition = FormStartPosition.CenterScreen;
                this.panelMain.Controls.Add(frmCanLamSan);
            }
            frmCanLamSan.WindowState = FormWindowState.Normal;
            frmCanLamSan.Show();
        }

        private void nhomCamLamSanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNhomCanLamSan frmNhomCanLamSan;
            frmNhomCanLamSan = new FrmNhomCanLamSan(db);
            frmNhomCanLamSan.ShowDialog();
        }
    }
}
