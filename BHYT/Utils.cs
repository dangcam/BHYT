using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
        public static string ParseDates (string date)
        {
            try
            {
                return DateTime.ParseExact (date, "yyyyMMddHHmm", System.Globalization.CultureInfo.InvariantCulture).ToString ();
            }
            catch { return null; }
        }
        public static int ToInt(string value, int defaultvalue = 0)
        {
            try
            {
                return int.Parse (value);
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
    }
}
