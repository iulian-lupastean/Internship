
using System.Data;
using System.Data.SqlClient;

namespace Behavioral_Design_Pattern
{
    public class ImportData : IDataAccess
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-4NUOG8A;Initial Catalog=UNIT_TESTING_ASSIGNMENT;Integrated Security=True");
        public ConnectionState state()
        {
            return con.State;
        }
        public void SaveData(string sql, Location location)
        {
            con.Open();
            using (var command = new SqlCommand(sql, con))
            {

                command.ExecuteNonQuery();
            }
            con.Close();
        }


        public void open()
        {
            con.Open();
        }
        public List<City> readCities()
        {
            SqlCommand command;
            SqlDataReader dataReader;
            String sql;
            List<City> cities = new List<City>();
            sql = " SELECT * from City";
            command = new SqlCommand(sql, con);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                cities.Add(new City
                {
                    ID = (int)dataReader.GetValue(0),
                    Name = (string)dataReader.GetValue(1),

                });
            }
            return cities;
        }
        public List<Location> readLocations()
        {
            SqlCommand command;
            SqlDataReader dataReader;
            String sql;
            List<Location> locations = new List<Location>();
            sql = " SELECT * from Locations";
            command = new SqlCommand(sql, con);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                locations.Add(new Location
                {
                    ID = (int)dataReader.GetValue(0),
                    Name = (string)dataReader.GetValue(1),
                    City_ID = (int)dataReader.GetValue(2),
                    Address = (string)dataReader.GetValue(3),
                    Price = (double)dataReader.GetValue(4),
                    Type = (string)dataReader.GetValue(5)
                });
            }
            return locations;
        }

        public void close()
        {
            con.Close();
        }
    }
}
