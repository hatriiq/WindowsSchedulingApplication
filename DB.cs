using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Data.SqlClient;
using C969Scheduling;

namespace C969Scheduling
{
    class DB
    {

        public static string connString = "Host=localhost;Port=3306;Database=client_schedule;Username=sqlUser;Password=Passw0rd!";
        public static MySqlConnection conn = new MySqlConnection(connString);

        public static List<User> GetUsers()
        {
            List<User> listOfUsers = new List<User>();
            string query = "select * from user";

            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                int userID = Convert.ToInt32(dataReader[0]);
                string userName = dataReader[1].ToString();
                string password = dataReader[2].ToString();
                int active = Convert.ToInt32(dataReader[3]);
                DateTime createDate = Convert.ToDateTime(dataReader[4]).ToLocalTime();
                string createdBy = dataReader[5].ToString();
                DateTime lastUpdate = Convert.ToDateTime(dataReader[6]).ToLocalTime();
                string lastUpdateBy = dataReader[7].ToString();

                listOfUsers.Add(new User(userID, userName, password, active, createDate, createdBy, lastUpdate, lastUpdateBy));
            }

            conn.Close();

            return listOfUsers;
        }

        public static void GetAppointments()
        {
            string query = $"select * from appointment where userId={MainHubForm.LoggedInUser.UserID}";

            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                int appointmentId = Convert.ToInt32(dataReader[0]);
                int customerId = Convert.ToInt32(dataReader[1]);
                int userId = Convert.ToInt32(dataReader[2]);
                string type = dataReader[7].ToString();
                DateTime start = Convert.ToDateTime(dataReader[9]).ToLocalTime();
                DateTime end = Convert.ToDateTime(dataReader[10]).ToLocalTime();
                DateTime createDate = Convert.ToDateTime(dataReader[11]).ToLocalTime();
                string createdBy = dataReader[12].ToString();
                DateTime lastUpdate = Convert.ToDateTime(dataReader[13]).ToLocalTime();
                string lastUpdateBy = dataReader[14].ToString();

                MainHubForm.ListOfAppointments.Add(new Apt(appointmentId, customerId, userId, type, start, end, createDate, createdBy, lastUpdate, lastUpdateBy));
            }
            conn.Close();
        }

        public static void AddAppointment(int customerId, string type, DateTime start, DateTime end)
        {
            DateTime now = DateTime.Now;
            var addedAppointment = new Apt(customerId, MainHubForm.LoggedInUser.UserID, type, start, end, now, MainHubForm.LoggedInUser.UserName, now, MainHubForm.LoggedInUser.UserName);

            conn.Open();
            string query = $"insert into `appointment` values ({addedAppointment.AppointmentId},{addedAppointment.CustomerId},{addedAppointment.UserId},'not needed','not needed','not needed','not needed','{addedAppointment.Type}','not needed','{addedAppointment.Start.ToUniversalTime().ToString("yy-MM-dd HH:mm:ss", DateTimeFormatInfo.InvariantInfo)}','{addedAppointment.End.ToUniversalTime().ToString("yy-MM-dd HH:mm:ss", DateTimeFormatInfo.InvariantInfo)}','{addedAppointment.CreateDate.ToUniversalTime().ToString("yy-MM-dd HH:mm:ss", DateTimeFormatInfo.InvariantInfo)}','{addedAppointment.CreatedBy}','{addedAppointment.LastUpdate.ToUniversalTime().ToString("yy-MM-dd HH:mm:ss", DateTimeFormatInfo.InvariantInfo)}','{addedAppointment.LastUpdateBy}')";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

            MainHubForm.ListOfAppointments.Add(addedAppointment);
        }

        public static void DeleteAppointment(Apt appointment)
        {
            conn.Open();
            string query = $"delete from appointment where appointmentId={appointment.AppointmentId};";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MainHubForm.ListOfAppointments.Remove(appointment);
        }

        public static void UpdateAppointment(Apt appointment, int customerId, string type, DateTime start, DateTime end)
        {
            DateTime now = DateTime.Now;
            string nowString = now.ToUniversalTime().ToString("yy-MM-dd HH:mm:ss", DateTimeFormatInfo.InvariantInfo);
            conn.Open();
            string query = $"update appointment set customerId={customerId},userId={MainHubForm.LoggedInUser.UserID},type='{type}',start='{start.ToUniversalTime().ToString("yy-MM-dd HH:mm:ss", DateTimeFormatInfo.InvariantInfo)}',end='{end.ToUniversalTime().ToString("yy-MM-dd HH:mm:ss", DateTimeFormatInfo.InvariantInfo)}',lastUpdate='{nowString}',lastUpdateBy='{MainHubForm.LoggedInUser.UserName}' WHERE appointmentId={appointment.AppointmentId};";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

            Apt updatedAppointment = new Apt(appointment.AppointmentId, customerId, MainHubForm.LoggedInUser.UserID, type, start, end, appointment.CreateDate, appointment.CreatedBy, now, MainHubForm.LoggedInUser.UserName);
            int indexOfAppointmentList = MainHubForm.ListOfAppointments.IndexOf(appointment);
            MainHubForm.ListOfAppointments.RemoveAt(indexOfAppointmentList);
            MainHubForm.ListOfAppointments.Insert(indexOfAppointmentList, updatedAppointment);
        }

        public static void GetCustomers()
        {
            string query = "select * from customer";

            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                int customerID = Convert.ToInt32(dataReader[0]);
                string customerName = dataReader[1].ToString();
                int addressID = Convert.ToInt32(dataReader[2]);
                int active = Convert.ToInt32(dataReader[3]);
                DateTime createDate = Convert.ToDateTime(dataReader[4]).ToLocalTime();
                string createdBy = dataReader[5].ToString();
                DateTime lastUpdate = Convert.ToDateTime(dataReader[6]).ToLocalTime();
                string lastUpdateBy = dataReader[7].ToString();

                MainHubForm.ListOfCustomers.Add(new Customer(customerID, customerName, addressID, active, createDate, createdBy, lastUpdate, lastUpdateBy));
            }

            conn.Close();
        }

        public static int AddCustomer(string customerName, int addressID, string user)
        {
            DateTime now = DateTime.Now;
            var addedCustomer = new Customer(customerName, addressID, 1, now, user, now, user);

            conn.Open();
            string query = $"insert into `customer` values ({addedCustomer.CustomerId}, '{addedCustomer.CustomerName}', {addedCustomer.AddressId}, {addedCustomer.Active}, '{addedCustomer.CreateDate.ToUniversalTime().ToString("yy-MM-dd HH:mm:ss", DateTimeFormatInfo.InvariantInfo)}', '{addedCustomer.CreatedBy}', '{addedCustomer.LastUpdate.ToUniversalTime().ToString("yy-MM-dd HH:mm:ss", DateTimeFormatInfo.InvariantInfo)}', '{addedCustomer.LastUpdateBy}')";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

            MainHubForm.ListOfCustomers.Add(addedCustomer);
            return addedCustomer.CustomerId;
        }

        public static void DeleteCustomer(Customer customer)
        {
            conn.Open();
            string query = $"delete from customer where customerId={customer.CustomerId};";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MainHubForm.ListOfCustomers.Remove(customer);
            DeleteAddress(customer.AddressId);
        }

        public static void UpdateCustomer(Customer customer, string customerName, string user)
        {
            DateTime now = DateTime.Now;
            string nowStr = now.ToUniversalTime().ToString("yy-MM-dd HH:mm:ss", DateTimeFormatInfo.InvariantInfo);
            conn.Open();
            string query = $"update customer set customerName='{customerName}', lastUpdate='{nowStr}', lastUpdateBy='{user}' WHERE customerId={customer.CustomerId};";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

            Customer updatedCustomer = new Customer(customer.CustomerId, customerName, customer.AddressId, customer.Active, customer.CreateDate, customer.CreatedBy, now, user);
            int indexOfCustomerList = MainHubForm.ListOfCustomers.IndexOf(customer);
            MainHubForm.ListOfCustomers.RemoveAt(indexOfCustomerList);
            MainHubForm.ListOfCustomers.Insert(indexOfCustomerList, updatedCustomer);
        }


        public static void GetAddresses()
        {
            string query = "select * from address";

            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                int addressID = Convert.ToInt32(dataReader[0]);
                string address1 = dataReader[1].ToString();
                string address2 = dataReader[2].ToString();
                int cityID = Convert.ToInt32(dataReader[3]);
                string postalCode = dataReader[4].ToString();
                string phone = dataReader[5].ToString();
                DateTime createDate = Convert.ToDateTime(dataReader[6]).ToLocalTime();
                string createdBy = dataReader[7].ToString();
                DateTime lastUpdate = Convert.ToDateTime(dataReader[8]).ToLocalTime();
                string lastUpdateBy = dataReader[9].ToString();

                MainHubForm.AddressDictionary.Add(addressID, new Address(addressID, address1, address2, cityID, postalCode, phone, createDate, createdBy, lastUpdate, lastUpdateBy));
            }
            conn.Close();
        }

        public static int AddAddress(string address1, string address2, int cityId, string postalCode, string phone, string userName)
        {
            DateTime now = DateTime.Now;
            var addedAddress = new Address(address1, address2, cityId, postalCode, phone, now, userName, now, userName);

            conn.Open();
            string query = $"insert into `address` values ({addedAddress.AddressId}, '{addedAddress.AddressLine}', '{addedAddress.AddressLine2}', {addedAddress.CityId}, '{addedAddress.PostalCode}', '{addedAddress.Phone}', '{addedAddress.CreateDate.ToUniversalTime().ToString("yy-MM-dd HH:mm:ss", DateTimeFormatInfo.InvariantInfo)}', '{addedAddress.CreatedBy}', '{addedAddress.LastUpdate.ToUniversalTime().ToString("yy-MM-dd HH:mm:ss", DateTimeFormatInfo.InvariantInfo)}', '{addedAddress.LastUpdateBy}')";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

            MainHubForm.AddressDictionary.Add(addedAddress.AddressId, addedAddress);
            return addedAddress.AddressId;
        }

        public static void DeleteAddress(int addressID)
        {
            conn.Open();
            string query = $"delete from address where addressId={addressID};";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MainHubForm.AddressDictionary.Remove(addressID);
        }

        public static void UpdateAddress(Address address, string address1, string address2, int cityId, string postalCode, string phone, string user)
        {
            DateTime now = DateTime.Now;
            string nowString = now.ToUniversalTime().ToString("yy-MM-dd HH:mm:ss", DateTimeFormatInfo.InvariantInfo);
            conn.Open();
            string query = $"update address set address='{address1}', address2='{address2}', cityId={cityId}, postalCode='{postalCode}', phone='{phone}', lastUpdate='{nowString}', lastUpdateBy='{user}' WHERE addressId={address.AddressId};";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

            MainHubForm.AddressDictionary[address.AddressId] = new Address(address.AddressId, address1, address2, cityId, postalCode, phone, address.CreateDate, address.CreatedBy, now, user);
        }

        public static void GetCities()
        {
            string query = "select * from city";

            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                int cityID = Convert.ToInt32(dataReader[0]);
                string city = dataReader[1].ToString();
                int countryID = Convert.ToInt32(dataReader[2]);
                DateTime createDate = Convert.ToDateTime(dataReader[3]).ToLocalTime();
                string createdBy = dataReader[4].ToString();
                DateTime lastUpdate = Convert.ToDateTime(dataReader[5]).ToLocalTime();
                string lastUpdateBy = dataReader[6].ToString();

                MainHubForm.CityDictionary.Add(cityID, new City(cityID, city, countryID, createDate, createdBy, lastUpdate, lastUpdateBy));
            }
            conn.Close();
        }

        public static void GetCountries()
        {
            string query = "select * from country";

            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                int countryID = Convert.ToInt32(dataReader[0]);
                string country = dataReader[1].ToString();
                DateTime createDate = Convert.ToDateTime(dataReader[2]).ToLocalTime();
                string createdBy = dataReader[3].ToString();
                DateTime lastUpdate = Convert.ToDateTime(dataReader[4]).ToLocalTime();
                string lastUpdateBy = dataReader[5].ToString();

                MainHubForm.CountryDictionary.Add(countryID, new Country(countryID, country, createDate, createdBy, lastUpdate, lastUpdateBy));
            }
            conn.Close();
        }
    }
}
