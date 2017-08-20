using System;
using System.Net.Http;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.IO;
using System.Web.Script.Serialization;
using System.Drawing;

namespace BHYT
{
    public partial class FrmKiemTra : Form
    {
        public FrmKiemTra ()
        {
            InitializeComponent ();
        }

        private async void btnKiemTra_Click (object sender, EventArgs e)
        {
            if (!checkInput ())
                return;
            IEnumerable<KeyValuePair<string, string>> queries = new List<KeyValuePair<string, string>> ()
            {
                new KeyValuePair<string, string>("MaThe",txtBHYT.Text),
                new KeyValuePair<string, string>("HoTen",txtHoTen.Text),
                new KeyValuePair<string, string>("NgaySinh",txtNgaySinh.Text)
            };
            HttpContent q = new FormUrlEncodedContent (queries);
            using (HttpClient client = new HttpClient ())
            {
                try
                {
                    using (HttpResponseMessage response = await client.PostAsync ("https://gdbhyt.baohiemxahoi.gov.vn/ThongTuyenLSKCB/CheckMaThe", q))
                    {

                        if (response.IsSuccessStatusCode)
                        {

                            using (HttpContent content = response.Content)
                            {
                                //MessageBox.Show (content.Headers.ToString ());
                                string mycontent = await content.ReadAsStringAsync ();
                                int iMessage = mycontent.IndexOf ("message");
                                int iCode = mycontent.IndexOf ("code");
                                string code = mycontent.Substring (iCode + 4, iMessage - (iCode + 4));
                                code = code.Replace ("\"", "").Replace (":", "").Replace (",", "");
                                string message = mycontent.Substring (iMessage + 7);
                                StringBuilder sMessage = new StringBuilder (message);
                                sMessage = sMessage.Replace ("\"", "").Replace ("}", "").Replace ("\\u003c/b\\u003e", "").Replace ("\\u003cb\\u003e", "");
                                switch (code)
                                {
                                    case "1":
                                        hienThongTin (true, sMessage.ToString ());
                                        break;
                                    case "2":
                                        hienThongTin (false, sMessage.ToString ());
                                        break;
                                    case "31":
                                        hienThongBao ("#DF0101", sMessage.ToString ());
                                        break;
                                    case "32":
                                        hienThongBao ("#134F5C", sMessage.ToString ());
                                        break;
                                    case "33":
                                        hienThongBao ("#BF9000", sMessage.ToString ());
                                        break;
                                    case "4":
                                        hienThongBao ("#DF0101", sMessage.ToString ());
                                        break;
                                    case "5":
                                        hienThongBao ("#DF0101", sMessage.ToString ());
                                        break;
                                    case "false":
                                        hienThongBao ("#DF0101", "Không có thông tin!");
                                        break;
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show ("Không thể kết nối tới cổng bảo hiểm!" + response.RequestMessage);
                        }
                    }
                }
                catch
                {
                    MessageBox.Show ("Không có kết nối internet!");
                }

            }
        }
        private void hienThongTin(bool t, string mess)
        {
            if(t)
            {
                lblThongTin.ForeColor = System.Drawing.ColorTranslator.FromHtml ("#0070C0");
            }
            else
            {
                lblThongTin.ForeColor = System.Drawing.ColorTranslator.FromHtml ("#FF002F");
            }
            string[] mg = mess.Split ('!');
            lblThongTin.Text = mg[0].Replace (":", "");
            richTextBox.Text = mg[1] + '\n' + mg[2];
        }
        private void hienThongBao(string color, string mess)
        {
            lblThongTin.ForeColor = System.Drawing.ColorTranslator.FromHtml (color);
            lblThongTin.Text = mess.Replace (":", "");
            richTextBox.Text = "";
        }
        private void txtQR_KeyPress (object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtQR_Leave (null, null);
            }
        }
        private string hexToText (string hex)
        {
            int NumberChars = hex.Length / 2;
            byte[] bytes = new byte[NumberChars];
            using (var sr = new StringReader (hex))
            {
                for (int i = 0; i < NumberChars; i++)
                    bytes[i] =
                      Convert.ToByte (new string (new char[2] { (char) sr.Read (), (char) sr.Read () }), 16);
            }

            ////To get ASCII value of the hex string.
            //string ASCIIresult = System.Text.Encoding.ASCII.GetString (bytes);

            //To get the UTF8 value of the hex string
            string utf8result = System.Text.Encoding.UTF8.GetString (bytes);
            return utf8result;
        }

        private void txtBHYT_KeyPress (object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
               
                txtHoTen.Focus ();
            }
        }

        private void txtHoTen_KeyPress (object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
               
                txtNgaySinh.Focus ();
            }
        }

        private void txtNgaySinh_KeyPress (object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (!checkInput ())
                    return;
                btnKiemTra_Click (null, null);
            }
        }
        private bool checkInput()
        {
            if (txtBHYT.Text.Length != 15)
            {
                MessageBox.Show ("Nhập mã thẻ (gồm 15 ký tự)!");
                txtBHYT.SelectAll ();
                txtBHYT.Focus ();
                return false;
            }
            if (string.IsNullOrEmpty (txtHoTen.Text))
            {
                MessageBox.Show ("Nhập họ tên!");
                txtHoTen.SelectAll ();
                txtHoTen.Focus ();
                return false;
            }
            if (string.IsNullOrEmpty (txtNgaySinh.Text))
            {
                MessageBox.Show ("Nhập ngày sinh!");
                txtNgaySinh.SelectAll ();
                txtNgaySinh.Focus ();
                return false;
            }
            return true;
        }

        private void txtQR_Leave (object sender, EventArgs e)
        {
            if (txtQR.Text.Length > 0)
            {
                string[] qr = txtQR.Text.Split ('|');
                if (qr.Length == 15)
                {
                    txtBHYT.Text = qr[0];
                    txtHoTen.Text = hexToText (qr[1]);
                    txtNgaySinh.Text = qr[2];

                    btnKiemTra_Click (null, null);
                    return;
                }
                else
                {
                    MessageBox.Show ("Sai mã QR!");
                    txtQR.SelectAll ();
                    txtQR.Focus ();
                }
            }
        }

        private void FrmKiemTra_Load (object sender, EventArgs e)
        {
            lblThongTin.Text = "";
            richTextBox.Text = "";
            this.ActiveControl = txtQR;
        }
    }
}
