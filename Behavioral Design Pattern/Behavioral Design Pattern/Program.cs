
namespace Behavioral_Design_Pattern
{
    public static class Behavioral_Design_Pattern
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select Prefered Locations! 1 -> Museum; 2 -> Park; 3 -> Famous Building");
            var selection = int.Parse(Console.ReadLine());
            var context = new ShowPreferedLocationsContext();
            if (selection == 1)
            {
                context.SeeStrategy(new ShowMuseumsFirst());
                context.ShowPreferedLocations(_cities.First(), _locations);
            }
            if (selection == 2)
            {
                context.SeeStrategy(new ShowParksFirst());
                context.ShowPreferedLocations(_cities.First(), _locations);
            }
            if (selection == 3)
            {
                context.SeeStrategy(new ShowFamousBuildingFirst());
                context.ShowPreferedLocations(_cities.First(), _locations);
            }

        }
        private static IEnumerable<City> _cities = CreateCityList();
        private static IEnumerable<City> CreateCityList()
        {
            return new List<City>
                {
                    new City { ID=1, Name ="Madrid"},
                    new City { ID=2, Name ="Paris"},
                    new City{ ID=3, Name ="London"},
                };
        }
        public static IEnumerable<Location> _locations = CreateLocationsList();
        public static IEnumerable<Location> CreateLocationsList()
        {
            return new List<Location>
            {
                new Location {ID=101, Name="Museo Nacional del Prado",City_ID=1,Address="C. de Ruiz de Alarcón, 23, 28014 Madrid, Spania",Price=19.99,Type="Museum"},
                new Location {ID=102, Name="Museo Lázaro Galdiano",City_ID=1,Address="C. Serrano, 122, 28006 Madrid, Spania",Price=19.99,Type="Museum"},
                new Location {ID=103, Name="Parque de Berlín",City_ID=1,Address="Av. de Ramón y Cajal, 2, 28016 Madrid, Spania",Price=19.99,Type="Park"},
                new Location {ID=104, Name="Parque María Eva Duarte de Perón",City_ID=1,Address="28028 Madrid, Spania",Price=19.99,Type="Park"},
                new Location {ID=105, Name="Monument to Christopher Columbus",City_ID=1,Address="Pl. de Colón, 28001 Madrid, Spania",Price=19.99,Type="Famous Building"},
                new Location {ID=106, Name="Las Ventas",City_ID=1,Address="C. de Alcalá, 237, 28028 Madrid, Spania",Price=19.99,Type="Famous Building"},
            };
        }

    }



}
