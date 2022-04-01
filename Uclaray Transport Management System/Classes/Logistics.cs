using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Uclaray_Transport_Management_System.Classes
{
    class Logistics
    {
        public int id {get; set;}
        public string name { get; set; }
        public bool active { get; set; }

        static string connstring = connstring = DBUtils.connstring;
        private MySqlConnection connection = new MySqlConnection(connstring);

        public List<Logistics> GetLogistics(bool activeOnly = true)
        {
            List<Logistics> _logisticsList = new List<Logistics>();
            string query;

            if (activeOnly==true)
            {
                query = "SELECT id, logistics_name, active FROM Logstics WHERE active=true";
            }

            query = "SELECT id, logistics_name, active FROM logistics ";

            using (connection)
            {
                connection.Open();

                MySqlCommand comm = new MySqlCommand(query, connection);

                //Execute Data reader
                MySqlDataReader dr = comm.ExecuteReader();

                //Populate List with data
                while (dr.Read())
                {
                    Logistics _logistics = new Logistics
                    {
                        id = (int)dr["id"],
                        name = dr["logistics_name"].ToString(),
                        active = Convert.ToBoolean(dr["active"])
                    };
                    _logisticsList.Add(_logistics);
                }

            }
                return _logisticsList;
        }

    }
}
