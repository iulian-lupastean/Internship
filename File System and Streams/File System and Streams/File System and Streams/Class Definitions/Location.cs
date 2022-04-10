namespace File_System_and_Streams.Class_Definitions
{
    public class Location
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public double Price { get; set; }
        public string LocationType { get; set; }

        public override string ToString()
        {
            return $"The Location {Name} is a {LocationType} found at {Address} and the visit price is {Price}";
        }
    }
}
