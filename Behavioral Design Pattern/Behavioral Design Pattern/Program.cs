
using System.Data.SqlClient;

namespace Behavioral_Design_Pattern
{

    public static class Behavioral_Design_Pattern
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Select Prefered Cities! 1 -> Madrid; 2 -> Paris; 3 -> London");
                var selectCity = int.Parse(Console.ReadLine());
                if (selectCity == 1)
                {
                    LocationsForSelectedCities(_cities.OrderByDescending(x => x.Name == "Madrid").First());
                }
                if (selectCity == 2)
                {
                    LocationsForSelectedCities(_cities.OrderByDescending(x => x.Name == "Paris").First());
                }
                if (selectCity == 3)
                {
                    LocationsForSelectedCities(_cities.OrderByDescending(x => x.Name == "London").First());
                }
            }


        }
        private static IEnumerable<City> _cities = CreateCityList();
        private static IEnumerable<City> CreateCityList()
        {
            List<City> cities = null;
            ImportData connection = new ImportData();
            connection.open();
            cities = connection.readCities();
            connection.close();

            return cities;
        }
        public static IEnumerable<Location> _locations = CreateLocationsList();
        public static IEnumerable<Location> CreateLocationsList()
        {
            List<Location> locations = null;
            ImportData connection = new ImportData();
            connection.open();
            locations = connection.readLocations();
            connection.close();

            return locations;

        }
        public static void LocationsForSelectedCities(City city)
        {
            Console.WriteLine("Select Prefered Locations! 1 -> Museum; 2 -> Park; 3 -> Famous Building");
            var selectedPreferedLocationType = int.Parse(Console.ReadLine());
            var context = new ShowPreferedLocationsContext();
            if (selectedPreferedLocationType == 1)
            {
                context.SeeStrategy(new ShowMuseumsFirst());
                foreach (var item in context.ShowPreferedLocations(city, _locations))
                {
                    Console.WriteLine(item);
                }
            }
            if (selectedPreferedLocationType == 2)
            {
                context.SeeStrategy(new ShowParksFirst());
                foreach (var item in context.ShowPreferedLocations(city, _locations))
                {
                    Console.WriteLine(item);
                }
            }
            if (selectedPreferedLocationType == 3)
            {
                context.SeeStrategy(new ShowFamousBuildingFirst());
                foreach (var item in context.ShowPreferedLocations(city, _locations))
                {
                    Console.WriteLine(item);
                }
            }
            Console.WriteLine();
        }

    }



}
