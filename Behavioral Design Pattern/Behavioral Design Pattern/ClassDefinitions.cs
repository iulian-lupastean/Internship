using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Behavioral_Design_Pattern
{

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
