using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace BHYT
{
    public class ReadConfig
    {
        XmlDocument xmlfile;
        public void Read ()
        {
            xmlfile = new XmlDocument ();
            xmlfile.Load ("config.xml");
            AppConfig.ServerName = xmlfile.SelectSingleNode ("config/server").InnerText.ToString ();
            AppConfig.Database = xmlfile.SelectSingleNode ("config/batabase").InnerText.ToString ();
            AppConfig.Username = xmlfile.SelectSingleNode ("config/user").InnerText.ToString ();
            AppConfig.Password = xmlfile.SelectSingleNode ("config/password").InnerText.ToString ();
            AppConfig.CoSoKCB = xmlfile.SelectSingleNode ("config/cosokcb").InnerText.ToString ();
            AppConfig.LuongCoBan = int.Parse(xmlfile.SelectSingleNode ("config/luongcoban").InnerText);
            AppConfig.SoPhong = int.Parse (xmlfile.SelectSingleNode ("config/sophong").InnerText);
            AppConfig.UserBhyt = xmlfile.SelectSingleNode("config/user_bhyt").InnerText.ToString();
            AppConfig.PassBhyt = xmlfile.SelectSingleNode("config/pass_bhyt").InnerText.ToString();
        }
        public void Write ()
        {
            xmlfile = new XmlDocument ();
            xmlfile.Load ("config.xml");
            xmlfile.SelectSingleNode ("config/server").InnerText = AppConfig.ServerName;
            xmlfile.SelectSingleNode ("config/batabase").InnerText = AppConfig.Database;
            xmlfile.SelectSingleNode ("config/user").InnerText = AppConfig.Username;
            xmlfile.SelectSingleNode ("config/password").InnerText = AppConfig.Password;
            xmlfile.SelectSingleNode ("config/cosokcb").InnerText = AppConfig.CoSoKCB;
            xmlfile.SelectSingleNode ("config/luongcoban").InnerText = AppConfig.LuongCoBan.ToString();
            xmlfile.SelectSingleNode ("config/sophong").InnerText = AppConfig.SoPhong.ToString ();
            xmlfile.Save ("config.xml");

        }
        public void ReadLogin ()
        {
            xmlfile = new XmlDocument ();
            xmlfile.Load ("UserLogin.xml");
            AppConfig.User = xmlfile.SelectSingleNode ("login/user").InnerText.ToString ();
            AppConfig.Pass = xmlfile.SelectSingleNode ("login/pass").InnerText.ToString ();
            AppConfig.Code_user = xmlfile.SelectSingleNode ("login/check").InnerText.ToString ();
        }
        public void WriteLogin ()
        {
            xmlfile = new XmlDocument ();
            xmlfile.Load ("UserLogin.xml");
            xmlfile.SelectSingleNode ("login/user").InnerText = AppConfig.User;
            xmlfile.SelectSingleNode ("login/pass").InnerText = AppConfig.Pass;
            xmlfile.SelectSingleNode ("login/check").InnerText = AppConfig.Code_user;
            xmlfile.Save ("UserLogin.xml");

        }
    }
}
