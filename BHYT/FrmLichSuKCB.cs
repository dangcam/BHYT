using BHYT.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BHYT
{
    public partial class FrmLichSuKCB : Form
    {
        public string KetQua = null;
        public string LichSu = null;
        public string ToKen = null;
        public string Id_ToKen = null;
        public DateTime Expires_In;
        KCBDAO kcb;
        FrmThongTinChiTiet frm = new FrmThongTinChiTiet();
        public FrmLichSuKCB(Connection db)
        {
            InitializeComponent();
            kcb = new KCBDAO(db);
            repositoryItemLookUpEdit.DataSource = kcb.DSKhamChuaBenh();
            repositoryItemLookUpEdit.DisplayMember = "TEN";
            repositoryItemLookUpEdit.ValueMember = "MA";
        }

        private void FrmLichSuKCB_Load(object sender, EventArgs e)
        {
            string maKQ = KetQua.Split(',')[0].Split(':')[1];
            switch(maKQ)
            {
                case "000":
                    this.lblThongTin.ForeColor = System.Drawing.Color.Blue;
                    lblThongTin.Text = "Thông tin thẻ chính xác.";
                    break;
                case "001":
                    this.lblThongTin.ForeColor = System.Drawing.Color.DarkRed;
                    lblThongTin.Text = "Thẻ do BHXH Bộ Quốc Phòng quản lý, đề nghị kiểm tra thẻ và thông tin giấy tờ tùy thân.";
                    break;
                case "002":
                    this.lblThongTin.ForeColor = System.Drawing.Color.DarkRed;
                    lblThongTin.Text = "Thẻ do BHXH Bộ Công An quản lý, đề nghị kiểm tra thẻ và thông tin giấy tờ tùy thân.";
                    break;
                case "010":
                    this.lblThongTin.ForeColor = System.Drawing.Color.DarkRed;
                    lblThongTin.Text = "Thẻ hết hạn sử dụng.";
                    break;
                case "051":
                    this.lblThongTin.ForeColor = System.Drawing.Color.DarkRed;
                    lblThongTin.Text = "Mã thẻ không đúng.";
                    break;
                case "052":
                    this.lblThongTin.ForeColor = System.Drawing.Color.DarkRed;
                    lblThongTin.Text = "Mã tỉnh cấp thẻ (ký tự thứ 4,5 của mã thẻ) không đúng.";
                    break;
                case "053":
                    this.lblThongTin.ForeColor = System.Drawing.Color.DarkRed;
                    lblThongTin.Text = "Mã quyền lợi thẻ (ký tự 3 của mã thẻ) không đúng.";
                    break;
                case "050":
                    this.lblThongTin.ForeColor = System.Drawing.Color.DarkRed;
                    lblThongTin.Text = "Không thấy thông tin thẻ BHXH.";
                    break;
                case "060":
                    this.lblThongTin.ForeColor = System.Drawing.Color.DarkRed;
                    lblThongTin.Text = "Thẻ sai họ tên";
                    break;
                case "061":
                    this.lblThongTin.ForeColor = System.Drawing.Color.DarkRed;
                    lblThongTin.Text = "Thẻ sai họ tên (đúng ký tự đầu)";
                    break;
                case "070":
                    this.lblThongTin.ForeColor = System.Drawing.Color.DarkRed;
                    lblThongTin.Text = "Thẻ sai ngày sinh.";
                    break;
                case "080":
                    this.lblThongTin.ForeColor = System.Drawing.Color.DarkRed;
                    lblThongTin.Text = "Thẻ sai giới tính";
                    break;
                case "090":
                    this.lblThongTin.ForeColor = System.Drawing.Color.DarkRed;
                    lblThongTin.Text = "Thẻ sai nơi đăng ký KCB ban đầu.";
                    break;
                case "100":
                    this.lblThongTin.ForeColor = System.Drawing.Color.DarkRed;
                    lblThongTin.Text = "Lỗi khi lấy dữ liệu sổ thẻ.";
                    break;
                case "101":
                    this.lblThongTin.ForeColor = System.Drawing.Color.DarkRed;
                    lblThongTin.Text = "Lỗi server.";
                    break;
                case "110":
                    this.lblThongTin.ForeColor = System.Drawing.Color.DarkRed;
                    lblThongTin.Text = "Thẻ đã thu hồi.";
                    break;
                case "120":
                    this.lblThongTin.ForeColor = System.Drawing.Color.DarkRed;
                    lblThongTin.Text = "Thẻ báo giảm.";
                    break;
                case "121":
                    this.lblThongTin.ForeColor = System.Drawing.Color.DarkRed;
                    lblThongTin.Text = "Thẻ báo giảm. Giảm chuyển ngoại tỉnh.";
                    break;
                case "122":
                    this.lblThongTin.ForeColor = System.Drawing.Color.DarkRed;
                    lblThongTin.Text = "Thẻ báo giảm. Giảm chuyển nội tỉnh.";
                    break;
                case "123":
                    this.lblThongTin.ForeColor = System.Drawing.Color.DarkRed;
                    lblThongTin.Text = "Thẻ báo giảm. Thu hồi do tăng lại cùng đơn vị.";
                    break;
                case "124":
                    this.lblThongTin.ForeColor = System.Drawing.Color.DarkRed;
                    lblThongTin.Text = "Thẻ báo giảm. Ngừng tham gia.";
                    break;
                case "130":
                    this.lblThongTin.ForeColor = System.Drawing.Color.DarkRed;
                    lblThongTin.Text = "Trẻ em không xuất trình thẻ.";
                    break;
                default:
                    lblThongTin.Text = "Mã kết quả: " + maKQ;
                    break;
            }
            if(LichSu.IndexOf('[')>0)
            {
                LichSu = LichSu.Substring(LichSu.IndexOf('['), LichSu.IndexOf(']')).Replace("]","").Replace("[","");
                string[] danhsach = LichSu.Split('}');
                DataTable data = new DataTable();
                data.Columns.Add("maHoSo", typeof(string));
                data.Columns.Add("maCSKCB", typeof(string));
                data.Columns.Add("tuNgay", typeof(string));
                data.Columns.Add("denNgay", typeof(string));
                data.Columns.Add("tenBenh", typeof(string));
                data.Columns.Add("tinhTrang", typeof(string));
                data.Columns.Add("kqDieuTri", typeof(string));
                foreach(string hoso in danhsach)
                {
                    if (hoso.Length > 0)
                    {
                        string[] dulieu = hoso.Replace("}", "").Replace("{", "").Split(',');
                        DataRow dr = data.NewRow();
                        foreach (string column in dulieu)
                        {
                            if (column.Split(':').Length > 1)
                            {
                                dr[column.Split(':')[0]] = column.Split(':')[1];
                            }
                        }
                        data.Rows.Add(dr);
                    }
                }
                gridControl.DataSource = data;
            }
        }

        private void gridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if(e.Column.Name == "tinhTrang")
            {
                switch(e.DisplayText)
                {
                    case "1":
                        e.DisplayText = "Ra viện";
                        break;
                    case "2":
                        e.DisplayText = "Chuyển viện";
                        break;
                    case "3":
                        e.DisplayText = "Trốn viện";
                        break;
                    case "4":
                        e.DisplayText = "Xin ra viện";
                        break;
                }
            }
            else
            if(e.Column.Name == "kqDieuTri")
            {
                switch (e.DisplayText)
                {
                    case "1":
                        e.DisplayText = "Khỏi";
                        break;
                    case "2":
                        e.DisplayText = "Đỡ";
                        break;
                    case "3":
                        e.DisplayText = "Không thay đổi";
                        break;
                    case "4":
                        e.DisplayText = "Nặng hơn";
                        break;
                    case "5":
                        e.DisplayText = "Tử vong";
                        break;
                }
            }
        }

        private async void btneditChiTiet_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string maHoSo = gridView.GetFocusedDataRow()["maHoSo"].ToString();
            IEnumerable<KeyValuePair<string, string>> values = new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string>("username",AppConfig.UserBhyt),
                new KeyValuePair<string, string>("password",Utils.ToMD5(AppConfig.PassBhyt))
            };
            HttpContent user = new FormUrlEncodedContent(values);
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    client.BaseAddress = new Uri("https://egw.baohiemxahoi.gov.vn/");
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                    if (Expires_In < DateTime.Now)
                    {
                        using (HttpResponseMessage response = await client.PostAsync("api/token/take", user))
                        {

                            if (response.IsSuccessStatusCode)
                            {

                                using (HttpContent content = response.Content)
                                {
                                    //MessageBox.Show (content.Headers.ToString ());
                                    string mycontent = await content.ReadAsStringAsync();
                                    mycontent = mycontent.Replace("\"", "").Replace("{", "").Replace("}", "");
                                    string[] kq = mycontent.Split(',');
                                    string maKetQua = kq[0].Split(':')[1];
                                    if (maKetQua.Equals("200"))
                                    {
                                        ToKen = kq[1].Split(':')[2];
                                        Id_ToKen = kq[2].Split(':')[1];
                                        Expires_In = Utils.ToDateTime(kq[5].Replace("expires_in:", ""));
                                    }
                                    else
                                    {
                                        MessageBox.Show(maKetQua + "-Lỗi xác thực!", "Lỗi");
                                        return;
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Không thể kết nối tới cổng bảo hiểm!" + response.RequestMessage, "Lỗi");
                                return;
                            }
                        }
                    }
                    // lấy lịch sử KCB
                    string data = string.Format("token={0}&id_token={1}&username={2}&password={3}&maHoSo={4}",
                        ToKen, Id_ToKen, AppConfig.UserBhyt, Utils.ToMD5(AppConfig.PassBhyt),maHoSo);
                    using (HttpResponseMessage response = await client.PostAsync("api/egw/nhanHoSoKCBChiTiet?" + data,null))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            using (HttpContent content = response.Content)
                            {
                                string mycontent = await content.ReadAsStringAsync();
                                string ketqua = mycontent.Split(',')[0].Split(':')[1].Replace("\"", "");
                                switch (ketqua)
                                {
                                    case "200":
                                        try
                                        {
                                            string xml2 = "", xml3 = "";
                                            if (mycontent.IndexOf("Xml2") > 0)
                                            {
                                                xml2 = mycontent.Substring(mycontent.IndexOf("Xml2"), mycontent.IndexOf("}]") - mycontent.IndexOf("Xml2") + 1);
                                                xml2 = xml2.Replace("Xml2\":[", "");
                                                mycontent=mycontent.Substring(mycontent.IndexOf("}]")+2);
                                            }
                                            if (mycontent.IndexOf("Xml3") > 0)
                                            {
                                                xml3 = mycontent.Substring(mycontent.IndexOf("Xml3"), mycontent.IndexOf("}]") - mycontent.IndexOf("Xml3") + 1);
                                                xml3 = xml3.Replace("Xml3\":[", "");
                                            }
                                            frm.XML2 = xml2;
                                            frm.XML3 = xml3;
                                            frm.ShowDialog();
                                        }
                                        catch { }
                                        break;
                                    default:
                                        MessageBox.Show("Lỗi không được xác thực.", "Lỗi - " + ketqua);
                                        break;
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Không thể kết nối tới cổng bảo hiểm!" + response.RequestMessage, "Lỗi");
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Không có kết nối internet!", "Lỗi");
                }
            }
        }
    }
}
