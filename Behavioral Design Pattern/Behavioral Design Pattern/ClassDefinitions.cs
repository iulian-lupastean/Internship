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
    }

}
