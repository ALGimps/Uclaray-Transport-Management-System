using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using MySql.Data.MySqlClient;
using System.Collections.Specialized;
using System.Net;

namespace Uclaray_Transport_Management_System.Classes
{
    public class SecurityUtils
    {
        public static string GenerateSalt(int nSalt)
        {
            var saltBytes = new byte[nSalt];

            using (var provider = new RNGCryptoServiceProvider())
            {
                provider.GetNonZeroBytes(saltBytes);
            }

            return Convert.ToBase64String(saltBytes);
        }

        public static string HashPassword(string password, string salt, int nIterations, int nHash)
        {
            var saltBytes = Convert.FromBase64String(salt);

            using (var rfc2898DeriveBytes = new Rfc2898DeriveBytes(password, saltBytes, nIterations))
            {
                return Convert.ToBase64String(rfc2898DeriveBytes.GetBytes(nHash));
            }
        }

        public static string GenerateHash(string Password, string Salt)
        {
            return HashPassword(Password, Salt, 1024, 64);
        }
    }

    public static class User
    {
        public static int UserId { get; set; }

        public static DateTime GetDateTime()
        {
            DateTime dateTime = DateTime.MinValue;
            System.Net.HttpWebRequest request = (System.Net.HttpWebRequest)System.Net.WebRequest.Create("http://www.microsoft.com");
            request.Method = "GET";
            request.Accept = "text/html, application/xhtml+xml, */*";
            request.UserAgent = "Mozilla/5.0 (compatible; MSIE 10.0; Windows NT 6.1; Trident/6.0)";
            request.ContentType = "application/x-www-form-urlencoded";
            request.CachePolicy = new System.Net.Cache.RequestCachePolicy(System.Net.Cache.RequestCacheLevel.NoCacheNoStore);
            System.Net.HttpWebResponse response = (System.Net.HttpWebResponse)request.GetResponse();
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string todaysDates = response.Headers["date"];

                dateTime = DateTime.ParseExact(todaysDates, "ddd, dd MMM yyyy HH:mm:ss 'GMT'",
                    System.Globalization.CultureInfo.InvariantCulture.DateTimeFormat, System.Globalization.DateTimeStyles.AssumeUniversal);
            }

            return dateTime;
        }

    }

    public static class DBUtils
    {

        //static string SERVER = "db4free.net";
        //static string USERID = "capstone_test";
        //static string PASSWORD = "capstone_test";
        //static string PORT = "3306";
        //static string DATABASE = "capstone_test";


        public static string SERVER = "localhost";
        static string USERID = "root";
        static string PASSWORD = "1234";
        static string PORT = "3306";
        static string DATABASE = "uclaray_product_tracking_management_system";

        public static string connstring = $"SERVER= {SERVER}; USER ID= {USERID}; PASSWORD= {PASSWORD}; PORT= {PORT}; DATABASE= {DATABASE};";

    }

    public static class LoggingUtils
    {
        public static void DeliveryLog(int TrackingID, int userID, string LogDetails)
        {
            DateTime LogDate = User.GetDateTime();
            string connstring = connstring = DBUtils.connstring;
            MySqlConnection connection = new MySqlConnection(connstring);

            string query = "INSERT INTO delivery_logs(tracking_id, user_id, log_detail, log_datetime) VALUES(?TrackingID,?userID,?LogDetails,?LogDate)";
            using (connection)
            {
                connection.Open();

                MySqlCommand comm = new MySqlCommand(query, connection);
                comm.Parameters.AddWithValue("?TrackingID", TrackingID);
                comm.Parameters.AddWithValue("?userID", userID);
                comm.Parameters.AddWithValue("?LogDetails", LogDetails);
                comm.Parameters.AddWithValue("?LogDate", LogDate);

                //Execute Query
                comm.ExecuteNonQuery();


            }

        }
    }

    public static class SMS{
        public static object Send(string number, string message)
        {
            using (WebClient client = new WebClient())
            {
                byte[] response =
                client.UploadValues("https://semaphore.co/api/v4/messages", new NameValueCollection()
                {
                    { "apikey", "fd22f047445626a75c326f141371210a" },
                    { "number", number },
                    { "message", message },
                    { "sendername", "" },
                });
                object result = Encoding.UTF8.GetString(response);
                return result;
            }
        }
    }
}
