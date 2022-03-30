namespace Behavioral_Design_Pattern
{

    public class ShowFamousBuildingFirst : IShowPreferedLocations
    {
        public void ShowPreferedLocations(City city, IEnumerable<Location> locations)
        {
            var showLocations = locations
                .Where(x => x.City_ID.Equals(city.ID)).OrderByDescending(x => x.Type == "Famous Building")
                .ThenBy(x => x.Type)
                .Select(x => x);
            foreach (var location in showLocations)
            { Console.WriteLine($"In {city.Name} you should visit {location.Name} on address {location.Address}.It's a {location.Type} and the cost is {location.Price} to visit"); }
        }

    }

}
