

namespace Behavioral_Design_Pattern
{
    public class ShowMuseumsFirst : IShowPreferedLocations
    {
        public IEnumerable<Location> ShowPreferedLocations(City city, IEnumerable<Location> locations)
        {
            var showLocations = locations
                .Where(x => x.City_ID.Equals(city.ID)).OrderByDescending(x => x.Type == "Museum")
                .ThenBy(x => x.Type)
                .Select(x => x);
            return showLocations;
        }

    }
}
