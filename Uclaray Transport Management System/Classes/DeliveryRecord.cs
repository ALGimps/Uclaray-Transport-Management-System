using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Uclaray_Transport_Management_System.Classes
{

    class Trip
    {
        public string Trip_number { get; set; }
        public DateTime Trip_date { get; set; }
        public string Truck_type { get; set; }
        public string Plate_no { get; set; }
        public string Number_of_drop { get; set; }
        public string Number_of_trips { get; set; }
        public int Driver_id { get; set; }
        public int Helper_id { get; set; }

        static string connstring = connstring = DBUtils.connstring;
        private MySqlConnection connection = new MySqlConnection(connstring);

        public List<Trip> GetAllTrips(string AddQuery = "")
        {
            List<Trip> tripList = new List<Trip>();
            string query;

                query = "SELECT * FROM trips WHERE driver_id = 0 OR helper_id = 0 ORDER by trip_date";
            

            using (connection)
            {
                connection.Open();

                MySqlCommand comm = new MySqlCommand(query, connection);

                //Execute Data reader
                MySqlDataReader dr = comm.ExecuteReader();

                //Populate List with data
                while (dr.Read())
                {
                    Trip trip = new Trip
                    {
                        Trip_number = dr["trip_no"].ToString(),
                        Trip_date = (DateTime)dr["trip_date"],
                        Truck_type = dr["truck_type"].ToString(),
                        Plate_no = dr["plate_no"].ToString(),
                        Number_of_drop = dr["no_of_drop"].ToString(),
                        Number_of_trips = dr["no_of_trip"].ToString(),
                        Driver_id = (int)dr["driver_id"],
                        Helper_id = (int)dr["helper_id"]
                    };
                    tripList.Add(trip);
                }

            }

            return tripList;
        }

        public void AddTrip(string TripNo, string TripDate, string TruckType, string PlateNo, int Trips, int Drops)
        {
            using (connection)
            {
                connection.Open();

                string query = "INSERT IGNORE INTO trips(trip_no, trip_date, truck_type, plate_no, no_of_drop,no_of_trip) " +
                    "           VALUES(?TripNo, ?TripDate, ?TruckType, ?PlateNo, ?Trips, ?Drops)";

                //Initialize Command
                MySqlCommand comm = new MySqlCommand(query, connection);
                comm.Parameters.AddWithValue("?TripNo", TripNo);
                comm.Parameters.AddWithValue("?TripDate", TripDate);
                comm.Parameters.AddWithValue("?TruckType", TruckType);
                comm.Parameters.AddWithValue("?PlateNo", PlateNo);
                comm.Parameters.AddWithValue("?Trips", Trips);
                comm.Parameters.AddWithValue("?Drops", Drops);

                //Execute
                comm.ExecuteNonQuery();

            }

        }


        public void AssignDriverHelper(string TripNo, int DriverID, int HelperID)
        {
            string query = "UPDATE trips SET driver_id = ?DriverID, helper_id = ?HelperID WHERE trip_no = ?TripNo;" +
                            " UPDATE delivery_records set status = 2 WHERE trip_id = ?TripNo";
            using (connection)
            {
                connection.Open();

                MySqlCommand comm = new MySqlCommand(query, connection);
                //comm.Parameters.AddWithValue("?RecordID", RecordID);
                comm.Parameters.AddWithValue("?DriverID", DriverID);
                comm.Parameters.AddWithValue("?HelperID", HelperID);
                comm.Parameters.AddWithValue("?TripNo", TripNo);

                //Execute Query
                comm.ExecuteNonQuery();

                //LoggingUtils.DeliveryLog(RecordID, UtilityClass.UserId, "Assigned Employees");

            }

        }

    }



    class DeliveryRecord
    {
        [System.ComponentModel.DisplayName("ID")]
        public int id { get; set; }
        public DateTime Delivery_date { get; set; }
        public int Logistics_id { get; set; }
        public string Store_name { get; set; }
        public string Location { get; set; }
        public string Area { get; set; }
        public string Trip_number { get; set; }
        public string Truck_type { get; set; }
        public string Plate_no { get; set; }
        public string Number_of_drop { get; set; }
        public string Number_of_trips { get; set; }
        public int Driver_id { get; set; }
        public int Helper_id { get; set; }
        public string PO_number { get; set; }
        public int Quantity { get; set; }
        public string Status { get; set; }
        public string Note { get; set; }
        public int User_id { get; set; }

        static string connstring = DBUtils.connstring;
        private MySqlConnection connection = new MySqlConnection(connstring);
        
        public List<DeliveryRecord> GetAllRecords(int status = 0)
        {
            List<DeliveryRecord> recordList = new List<DeliveryRecord>();
            string query;


            if (status == 0)
            {
                query = "SELECT delivery_records.tracking_id, delivery_records.logistics_id, delivery_records.delivery_date , delivery_records.store_name, delivery_records.location, delivery_records.area, delivery_records.status, delivery_records.po_number ,  delivery_records.quantity, delivery_records.note, delivery_records.user_id, " +
                "trips.trip_no, trips.truck_type, trips.plate_no, trips.no_of_drop, trips.no_of_trip, trips.driver_id, trips.helper_id " +
                "FROM delivery_records " +
                "INNER JOIN trips ON trips.trip_no = delivery_records.trip_id " + 
                " ORDER by delivery_date";
            }
            else
            {
                query = "SELECT delivery_records.tracking_id, delivery_records.logistics_id, delivery_records.delivery_date , delivery_records.store_name, delivery_records.location, delivery_records.area, delivery_records.status, delivery_records.po_number, delivery_records.quantity, delivery_records.note, delivery_records.user_id, " +
                "trips.trip_no, trips.truck_type, trips.plate_no, trips.no_of_drop, trips.no_of_trip, trips.driver_id, trips.helper_id " +
                "FROM delivery_records " +
                "INNER JOIN trips ON trips.trip_no = delivery_records.trip_id " +
                " WHERE " + "status = " + status + 
                " ORDER by delivery_date";
            }



            using (connection)
            {
                connection.Open();

                MySqlCommand comm = new MySqlCommand(query, connection);

                //Execute Data reader
                MySqlDataReader dr = comm.ExecuteReader();

                //Populate List with data
                while (dr.Read())
                {
                    DeliveryRecord record = new DeliveryRecord
                    {
                        id = (int)dr["tracking_id"],
                        Delivery_date = (DateTime)(dr["delivery_date"]),
                        Logistics_id = (int)dr["logistics_id"],
                        Store_name = dr["store_name"].ToString(),
                        Location = dr["location"].ToString(),
                        Area = dr["area"].ToString(),
                        PO_number = dr["po_number"].ToString(),
                        Quantity = (int)dr["quantity"],
                        Trip_number = dr["trip_no"].ToString(),
                        Truck_type = dr["truck_type"].ToString(),
                        Plate_no = dr["plate_no"].ToString(),
                        Number_of_drop = dr["no_of_drop"].ToString(),
                        Number_of_trips = dr["no_of_trip"].ToString(),
                        Driver_id = (int)dr["driver_id"],
                        Helper_id = (int)dr["helper_id"],
                        Status = dr["status"].ToString(),
                        Note = dr["note"].ToString(),
                        User_id = (int)dr["user_id"]
                    };
                    recordList.Add(record);
                }

            }

            return recordList;
        }

        public List<DeliveryRecord> GetBadOrders()
        {
            List<DeliveryRecord> recordList = new List<DeliveryRecord>();
            string query = "SELECT delivery_records.tracking_id, delivery_records.logistics_id, delivery_records.delivery_date , delivery_records.store_name, delivery_records.location, delivery_records.area, delivery_records.status, delivery_records.po_number ,  delivery_records.quantity, delivery_records.note, delivery_records.user_id, " +
                "trips.trip_no, trips.truck_type, trips.plate_no, trips.no_of_drop, trips.no_of_trip, trips.driver_id, trips.helper_id " +
                "FROM delivery_records " +
                "INNER JOIN trips ON trips.trip_no = delivery_records.trip_id " +
                "WHERE status = 4 OR status = 5 "+
                "ORDER by delivery_date";

            using (connection)
            {
                connection.Open();

                MySqlCommand comm = new MySqlCommand(query, connection);

                //Execute Data reader
                MySqlDataReader dr = comm.ExecuteReader();

                //Populate List with data
                while (dr.Read())
                {
                    DeliveryRecord record = new DeliveryRecord
                    {
                        id = (int)dr["tracking_id"],
                        Delivery_date = (DateTime)(dr["delivery_date"]),
                        Logistics_id = (int)dr["logistics_id"],
                        Store_name = dr["store_name"].ToString(),
                        Location = dr["location"].ToString(),
                        Area = dr["area"].ToString(),
                        PO_number = dr["po_number"].ToString(),
                        Quantity = (int)dr["quantity"],
                        Trip_number = dr["trip_no"].ToString(),
                        Truck_type = dr["truck_type"].ToString(),
                        Plate_no = dr["plate_no"].ToString(),
                        Number_of_drop = dr["no_of_drop"].ToString(),
                        Number_of_trips = dr["no_of_trip"].ToString(),
                        Driver_id = (int)dr["driver_id"],
                        Helper_id = (int)dr["helper_id"],
                        Status = dr["status"].ToString(),
                        Note = dr["note"].ToString(),
                        User_id = (int)dr["user_id"]
                    };
                    recordList.Add(record);
                }

            }

            return recordList;
        }

        public List<DeliveryRecord> GetCompletedRecords()
        {
            List<DeliveryRecord> recordList = new List<DeliveryRecord>();
            string query = "SELECT delivery_records.tracking_id, delivery_records.logistics_id, delivery_records.delivery_date , delivery_records.store_name, delivery_records.location, delivery_records.area, delivery_records.status, delivery_records.po_number ,  delivery_records.quantity, delivery_records.note, delivery_records.user_id, " +
                "trips.trip_no, trips.truck_type, trips.plate_no, trips.no_of_drop, trips.no_of_trip, trips.driver_id, trips.helper_id " +
                "FROM delivery_records " +
                "INNER JOIN trips ON trips.trip_no = delivery_records.trip_id " +
                "WHERE status > 2 " +
                "ORDER by delivery_date";

            using (connection)
            {
                connection.Open();

                MySqlCommand comm = new MySqlCommand(query, connection);

                //Execute Data reader
                MySqlDataReader dr = comm.ExecuteReader();

                //Populate List with data
                while (dr.Read())
                {
                    DeliveryRecord record = new DeliveryRecord
                    {
                        id = (int)dr["tracking_id"],
                        Delivery_date = (DateTime)(dr["delivery_date"]),
                        Logistics_id = (int)dr["logistics_id"],
                        Store_name = dr["store_name"].ToString(),
                        Location = dr["location"].ToString(),
                        Area = dr["area"].ToString(),
                        PO_number = dr["po_number"].ToString(),
                        Quantity = (int)dr["quantity"],
                        Trip_number = dr["trip_no"].ToString(),
                        Truck_type = dr["truck_type"].ToString(),
                        Plate_no = dr["plate_no"].ToString(),
                        Number_of_drop = dr["no_of_drop"].ToString(),
                        Number_of_trips = dr["no_of_trip"].ToString(),
                        Driver_id = (int)dr["driver_id"],
                        Helper_id = (int)dr["helper_id"],
                        Status = dr["status"].ToString(),
                        Note = dr["note"].ToString(),
                        User_id = (int)dr["user_id"]
                    };
                    recordList.Add(record);
                }

            }

            return recordList;
        }

        public DeliveryRecord GetRecord(int RecordID, int status = 0)
        {
            DeliveryRecord recordResult = new DeliveryRecord();
            string query;


            query = "SELECT delivery_records.tracking_id, delivery_records.logistics_id, delivery_records.delivery_date , delivery_records.store_name, delivery_records.location, delivery_records.area, delivery_records.status, delivery_records.po_number ,  delivery_records.quantity, delivery_records.note, delivery_records.user_id, " +
            "trips.trip_no, trips.truck_type, trips.plate_no, trips.no_of_drop, trips.no_of_trip, trips.driver_id, trips.helper_id " +
            "FROM delivery_records " +
            "INNER JOIN trips ON trips.trip_no = delivery_records.trip_id " +
            "WHERE tracking_id = ?RecordID ";

            using (connection)
            {
                connection.Open();

                MySqlCommand comm = new MySqlCommand(query, connection);
                comm.Parameters.AddWithValue("?RecordID", RecordID);
                //Execute Data reader
                MySqlDataReader dr = comm.ExecuteReader();

                //Populate List with data
                while (dr.Read())
                {

                    recordResult.id = (int)dr["tracking_id"];
                    recordResult.Delivery_date = (DateTime)(dr["delivery_date"]);
                    recordResult.Logistics_id = (int)dr["logistics_id"];
                    recordResult.Store_name = dr["store_name"].ToString();
                    recordResult.Location = dr["location"].ToString();
                    recordResult.Area = dr["area"].ToString();
                    recordResult.PO_number = dr["po_number"].ToString();
                    recordResult.Quantity = (int)dr["quantity"];
                    recordResult.Trip_number = dr["trip_no"].ToString();
                    recordResult.Truck_type = dr["truck_type"].ToString();
                    recordResult.Plate_no = dr["plate_no"].ToString();
                    recordResult.Number_of_drop = dr["no_of_drop"].ToString();
                    recordResult.Number_of_trips = dr["no_of_trip"].ToString();
                    recordResult.Driver_id = (int)dr["driver_id"];
                    recordResult.Helper_id = (int)dr["helper_id"];
                    recordResult.Status = dr["status"].ToString();
                    recordResult.Note = dr["note"].ToString();
                    recordResult.User_id = (int)dr["user_id"];

                }

            }

            return recordResult;
        }

        public List<DeliveryRecord> GetRecordsOfTrip(string TripID)
        {
            List<DeliveryRecord> recordList = new List<DeliveryRecord>();
            string query;


                query = "SELECT delivery_records.tracking_id, delivery_records.logistics_id, delivery_records.delivery_date , delivery_records.store_name, delivery_records.location, delivery_records.area, delivery_records.status, delivery_records.po_number, delivery_records.quantity, delivery_records.note, delivery_records.user_id, " +
                "trips.trip_no, trips.truck_type, trips.plate_no, trips.no_of_drop, trips.no_of_trip, trips.driver_id, trips.helper_id " +
                "FROM delivery_records " +
                "INNER JOIN trips ON trips.trip_no = delivery_records.trip_id " +
                " WHERE " + "status = 1 AND trip_no = ?TripID" +
                " ORDER by delivery_date";
            

            using (connection)
            {
                connection.Open();

                MySqlCommand comm = new MySqlCommand(query, connection);
                comm.Parameters.AddWithValue("?TripID", TripID);

                //Execute Data reader
                MySqlDataReader dr = comm.ExecuteReader();

                //Populate List with data
                while (dr.Read())
                {
                    DeliveryRecord record = new DeliveryRecord
                    {
                        id = (int)dr["tracking_id"],
                        Store_name = dr["store_name"].ToString(),
                        Location = dr["location"].ToString(),
                        Area = dr["area"].ToString(),
                        Quantity = (int)dr["quantity"]
                        
                    };
                    recordList.Add(record);
                }

            }

            return recordList;
        }

        public void AddRecord(string DeliveryDate,string TripNo,int LogisticsID, string CustomerName, string Location, string Area, int Quantity, int UserID)
        {
            using (connection){
                connection.Open();

                string query = "INSERT IGNORE INTO delivery_records(trip_id, logistics_id, delivery_date, store_name, location, area, quantity, user_id) " +
                    "           VALUES(?TripNo , ?LogisticsID, ?DeliveryDate, ?CustomerName, ?Location, ?Area, ?Quantity, ?UserID)";

                    //Initialize Command
                    MySqlCommand comm = new MySqlCommand(query, connection);
                    comm.Parameters.AddWithValue("?TripNo", TripNo.Trim());
                    comm.Parameters.AddWithValue("?DeliveryDate", DeliveryDate.Trim());
                    comm.Parameters.AddWithValue("?CustomerName", CustomerName.Trim());
                    comm.Parameters.AddWithValue("?LogisticsID", LogisticsID);
                    comm.Parameters.AddWithValue("?Location", Location.Trim());
                    comm.Parameters.AddWithValue("?Area", Area.Trim());
                    comm.Parameters.AddWithValue("?Quantity", Quantity);
                    comm.Parameters.AddWithValue("?UserID", UserID);

                //Execute
                comm.ExecuteNonQuery();
                
            }
        }


        public void UpdatePONumber(int RecordID, string PONumber)
        {
            using (connection)
            {
                connection.Open();

                string query = "UPDATE delivery_records SET po_number = ?PONumber" +
                    "           WHERE tracking_id = ?RecordID ";

                //Initialize Command
                MySqlCommand comm = new MySqlCommand(query, connection);
                comm.Parameters.AddWithValue("?RecordID", RecordID);
                comm.Parameters.AddWithValue("?PONumber", PONumber.Trim());


                //Execute
                comm.ExecuteNonQuery();

            }
        }

        public void UpdateRecordStatus(int RecordID, int Status, string Note)
        {
            using (connection)
            {
                connection.Open();

                string query = "UPDATE delivery_records SET Status = ?Status, note = ?Note" +
                    "           WHERE tracking_id = ?RecordID ";

                //Initialize Command
                MySqlCommand comm = new MySqlCommand(query, connection);
                comm.Parameters.AddWithValue("?RecordID", RecordID);
                comm.Parameters.AddWithValue("?Status", Status);
                comm.Parameters.AddWithValue("?Note", Note.Trim());


                //Execute
                comm.ExecuteNonQuery();

            }
        }

    }

    class Status
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Status> GetStatuses()
        {
            List<Status> _statusList = new List<Status>() {
                new Status(){Id=2,Name="Pending"},
                new Status(){Id=3,Name="Successful"},
                new Status(){Id=4,Name="Bad Order (Logistics)"},
                new Status(){Id=5,Name="Bad Order (Uclaray)"},
                new Status(){Id=6,Name="Cancelled"},
            };

            return _statusList;
        }
    }

}
