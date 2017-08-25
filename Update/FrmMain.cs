using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v2;
using Google.Apis.Drive.v2.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using System.Xml;

namespace Update
{
    public partial class FrmMain : Form
    {
        const string FILEVERSION = "version.xml";
        const string FILEVERSIONNEW = "versionnew.xml";
        const string IDFILE = "0B4c2YR2ND8EZTG5oTEJET2J4cG8";
        const string IDFOLDER = "0B4c2YR2ND8EZU01QUTdXdEY4ekE";
        public FrmMain ()
        {
            InitializeComponent ();
        }
        static string[] Scopes = { DriveService.Scope.Drive };
        static string ApplicationName = "UpdateBHYT";
        string VersionCurrent = "";
        string VersionNew = "";
        private void FrmMain_Load (object sender, EventArgs e)
        {
            VersionCurrent = ReadVerison (FILEVERSION);
            UserCredential credential = GetCredentials ();
            // Create Drive API service.
            var service = new DriveService (new BaseClientService.Initializer ()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });
            DownLoadFile (service, IDFILE);
            VersionNew = ReadVerison (FILEVERSIONNEW);
            if(VersionNew != VersionCurrent)
            {
                PrintFilesInFolder (service, IDFOLDER);
                
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

                    foreach (ChildReference child in children.Items)
                    {
                        DownLoadFile (service, child.Id);
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
            WriteVersion ();
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
                        Console.WriteLine ("An error occurred: " + e.Message);
                    }
                }
            }
            catch (IOException e)
            {
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
    }
}
