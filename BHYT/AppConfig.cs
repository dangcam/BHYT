using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BHYT
{
    public class AppConfig
    {
        private static string username = "";
        private static string password = "";
        private static string cosokcb = "";
        private static string code_user = "";
        private static string servername = "";
        private static string database = "";
        private static int luongCoBan = 0;
        private static string user = "";
        private static string pass = "";
        private static int soPhong = 0;
        public static string Database
        {
            get
            {
                return database;
            }
            set
            {
                database = value;
            }
        }
        public static string ServerName
        {
            get
            {
                return servername;
            }
            set
            {
                servername = value;
            }
        }
        public static string Username
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
            }
        }
        public static string Code_user
        {
            get
            {
                return code_user;
            }
            set
            {
                code_user = value;
            }
        }
        public static string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }
        public static string CoSoKCB
        {
            get
            {
                return cosokcb;
            }
            set
            {
                cosokcb = value;
            }
        }

        public static int LuongCoBan
        {
            get
            {
                return luongCoBan;
            }

            set
            {
                luongCoBan = value;
            }
        }

        public static string User
        {
            get
            {
                return user;
            }

            set
            {
                user = value;
            }
        }

        public static string Pass
        {
            get
            {
                return pass;
            }

            set
            {
                pass = value;
            }
        }

        public static int SoPhong
        {
            get
            {
                return soPhong;
            }

            set
            {
                soPhong = value;
            }
        }
    }
}
