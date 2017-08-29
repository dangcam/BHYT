using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v2;
using Google.Apis.Drive.v2.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using Tulpep.NotificationWindow;

namespace Update
{
    public partial class FrmMain : Form
    {
        const string FILEVERSION = "version.xml";
        const string FILEVERSIONNEW = "versionnew.xml";
        const string IDFILE = "0B4c2YR2ND8EZTG5oTEJET2J4cG8";
        const string IDFOLDER = "0B4c2YR2ND8EZU01QUTdXdEY4ekE";
        BackgroundWorker bw = new BackgroundWorker ();
        static string[] Scopes = { DriveService.Scope.Drive };
        static string ApplicationName = "UpdateBHYT";
        string VersionCurrent = "";
        string VersionNew = "";
        DriveService service = null;
        public FrmMain ()
        {
            InitializeComponent ();
            bw.WorkerSupportsCancellation = true;
            bw.WorkerReportsProgress = true;
            bw.DoWork += new DoWorkEventHandler (bw_DoWork);
            bw.ProgressChanged += new ProgressChangedEventHandler (bw_ProgressChanged);
            bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler (bw_RunWorkerCompleted);
        }

        private void FrmMain_Load (object sender, EventArgs e)
        {
            VersionCurrent = ReadVerison (FILEVERSION);
            UserCredential credential = GetCredentials ();
            // Create Drive API service.
            service = new DriveService (new BaseClientService.Initializer ()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });
            DownLoadFile (service, IDFILE);
            VersionNew = ReadVerison (FILEVERSIONNEW);
            if (VersionNew != VersionCurrent && VersionNew != null)
            {
                Notification ();
                DialogResult traloi;
                traloi = MessageBox.Show ("BHYT có phiên bản mới, bạn có muốn cập nhật?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (traloi == DialogResult.Yes)
                {
                    if (bw.IsBusy != true)
                    {
                        TatBHYT ();
                        bw.RunWorkerAsync ();
                    }
                }
                else
                {
                    this.Close ();
                }
            }
            else
            {
                this.Close ();
            }
        }
        public void PrintFilesInFolder (DriveService service, String folderId)
        {
            ChildrenResource.ListRequest request = service.Children.List (folderId);
            do
            {
                try
                {
                    ChildList children = request.Execute ();
                    int i = 0;
                    float len = children.Items.Count;
                    foreach (ChildReference child in children.Items)
                    {
                        DownLoadFile (service, child.Id);
                        i++;
                        bw.ReportProgress ((int) (100 / len * i));
                    }
                    request.PageToken = children.NextPageToken;
                }
                catch (Exception e)
                {
                    Console.WriteLine ("An error occurred: " + e.Message);
                    request.PageToken = null;
                    return;
                }
            } while (!String.IsNullOrEmpty (request.PageToken));
        }
        private UserCredential GetCredentials ()
        {
            UserCredential credential;

            using (var stream = new FileStream ("client_secret.json", FileMode.Open, FileAccess.Read))
            {
                string credPath = (AppDomain.CurrentDomain.BaseDirectory);

                credPath = Path.Combine (credPath, "credentials_client_secreta.json");

                credential = GoogleWebAuthorizationBroker.AuthorizeAsync (
                    GoogleClientSecrets.Load (stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore (credPath, true)).Result;
                string t = string.Format ("Credential file saved to: " + credPath);
            }
            return credential;
        }
        private void DownLoadFile(DriveService service, string id)
        {
            Google.Apis.Drive.v2.Data.File file = null;
            try
            {
                file = service.Files.Get (id).Execute ();
                if (!String.IsNullOrEmpty (file.DownloadUrl))
                {
                    try
                    {
                        var get = service.HttpClient.GetByteArrayAsync (file.DownloadUrl);
                        byte[] arrBytes = get.Result;
                        System.IO.File.WriteAllBytes (file.Title, arrBytes);
                    }
                    catch (Exception e)
                    {
                        //MessageBox.Show("An error occurred: " + e.Message);
                    }
                }
            }
            catch
            {
                return;
            }
        }
        private string ReadVerison (string name)
        {
            try
            {
                XmlDocument xmlfile = new XmlDocument ();
                xmlfile.Load (name);
                return xmlfile.SelectSingleNode ("version").InnerText.ToString ();
            }
            catch { return null; }
        }
        public void WriteVersion ()
        {
            XmlDocument xmlfile = new XmlDocument ();
            xmlfile.Load (FILEVERSION);
            xmlfile.SelectSingleNode ("version").InnerText = VersionNew;
            xmlfile.Save (FILEVERSION);

        }
        private void bw_DoWork (object sender, DoWorkEventArgs e)
        {
            PrintFilesInFolder (service, IDFOLDER);
        }
        private void bw_ProgressChanged (object sender, ProgressChangedEventArgs e)
        {
            lblTienTrinh.Text = "Đang tải: " + e.ProgressPercentage + "%";
            progressBar.Value = (e.ProgressPercentage);
        }
        private void bw_RunWorkerCompleted (object sender, RunWorkerCompletedEventArgs e)
        {
            if ((e.Cancelled == true))
            {
                ChayLai ();
            }

            else if (!(e.Error == null))
            {
                ChayLai ();
            }
            else
            {
                DialogResult traloi;
                traloi = MessageBox.Show ("BHYT cập nhật hoàn tất, chạy lại ứng dụng?", "Trả lời",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (traloi == DialogResult.Yes)
                {
                    ChayLai ();
                }
            }
            WriteVersion ();
            this.Close ();
        }
        private void TatBHYT()
        {
            Process[] processes = Process.GetProcessesByName ("BHYT");
            if (processes.Length > 0)
                processes[0].Kill ();
        }
        private void ChayLai()
        {
            Process p = new Process ();
            p.StartInfo = new ProcessStartInfo ("BHYT.exe");
            p.StartInfo.WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory;
            p.StartInfo.CreateNoWindow = true;
            p.Start ();
            this.Close ();
        }
        private void Notification()
        {
            PopupNotifier popup = new PopupNotifier ();
            popup.Image = Properties.Resources.Notifications;
            popup.TitleText = "BHYT";
            popup.ContentText = "BHYT có phiên bản mới!";
            popup.Popup ();
        }
    }
}
