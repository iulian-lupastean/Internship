using System.Data.SqlClient;

namespace Behavioral_Design_Pattern
{
    public class ImportData
    {
        string connectionString = @"Data Source=DESKTOP-4NUOG8A;Initial Catalog=UNIT_TESTING_ASSIGNMENT;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection con;
        public ImportData()
        {
            con = new SqlConnection(connectionString);

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
    public class City
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    public class Location
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int City_ID { get; set; }

        public string Address { get; set; }
        public double Price { get; set; }
        public string Type { get; set; }

        public override string ToString()
        {
            return $"{ID} {Name} {City_ID} {Address} {Price} {Type}";
        }

        // override object.Equals
        public override bool Equals(object obj)
        {
            Location location = obj as Location;
            if (location == null)
            {
                return false;
            }
            else
            {
                return ID == location.ID && Name == location.Name && City_ID == location.City_ID && Address == location.Address && Price == location.Price && Type == location.Type;
            }



        }

    }

}
