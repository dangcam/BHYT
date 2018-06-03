using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BHYT
{
    public class Utils
    {
        public static string HexToText (string hex)
        {
            int NumberChars = hex.Length / 2;
            byte[] bytes = new byte[NumberChars];
            using (var sr = new StringReader (hex))
            {
                for (int i = 0; i < NumberChars; i++)
                    try
                    {
                        bytes[i] =
                          Convert.ToByte (new string (new char[2] { (char) sr.Read (), (char) sr.Read () }), 16);
                    }
                    catch { }
            }

            ////To get ASCII value of the hex string.
            //string ASCIIresult = System.Text.Encoding.ASCII.GetString (bytes);

            //To get the UTF8 value of the hex string
            string utf8result = System.Text.Encoding.UTF8.GetString (bytes);
            return utf8result;
        }
        public static string ParseDate (string date, bool f = false)
        {
            try
            {
                if (date.Length < 8)
                {
                    return date;
                }
                if (f)
                {
                    return DateTime.ParseExact (date, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture).ToString ("dd/MM/yyyy");
                }
                return DateTime.ParseExact (date, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture).ToString ();
            }catch
            {
                return null;
            }
        }
        public  static bool ToBool(object value, bool defaultvalue = false)
        {
            try
            {
                return Convert.ToBoolean(value);
            }
            catch
            {
                return defaultvalue;
            }
        }
        public static string ParseDates (string date)
        {
            try
            {
                return DateTime.ParseExact (date, "yyyyMMddHHmm", System.Globalization.CultureInfo.InvariantCulture).ToString ();
            }
            catch { return null; }
        }
        public static string ParseDates(string date,string format)
        {
            try
            {
                return DateTime.ParseExact(date, "yyyyMMddHHmm", System.Globalization.CultureInfo.InvariantCulture).ToString(format);
            }
            catch { return null; }
        }
        public static DateTime ParseDate(string date)
        {
            try
            {
                return DateTime.ParseExact(date, "yyyyMMddHHmm", System.Globalization.CultureInfo.InvariantCulture);
            }
            catch { return DateTime.Now; }
        }
        public static decimal ToDecimal(object value, decimal defaultvalue = 0)
        {
            try
            {
                return Convert.ToDecimal(value);
            }
            catch { return defaultvalue; }
        }
        public static int ToInt(string value, int defaultvalue = 0)
        {
            try
            {
                return int.Parse (value);
            }
            catch { return defaultvalue; }
        }
        public static float ToFloat(string value, int defaultvalue = 0)
        {
            try
            {
                return float.Parse(value);
            }
            catch { return defaultvalue; }
        }
        public static double ToDouble(string value, double defaultvalue = 0)
        {
            try
            {
                return double.Parse(value);
            }
            catch { return defaultvalue; }
        }
        public static string ToString(object value, string defaultvalue = null)
        {
            try
            {
                return value.ToString();
            }
            catch
            {
                return defaultvalue;
            }
        }
        public static DateTime ToDateTime(object value)
        {
            try
            {
                return Convert.ToDateTime(value);
            }
            catch
            {
                return DateTime.Now;
            }
        }
        public static string ToMD5(string source)
        {
            using (MD5 md5Hash = MD5.Create())
            {
                return  GetMd5Hash(md5Hash, source);
            }
        }
        private static string GetMd5Hash(MD5 md5Hash, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }
        public static bool VerifyMd5Hash(MD5 md5Hash, string input, string hash)
        {
            // Hash the input.
            string hashOfInput = GetMd5Hash(md5Hash, input);

            // Create a StringComparer an compare the hashes.
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            if (0 == comparer.Compare(hashOfInput, hash))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
