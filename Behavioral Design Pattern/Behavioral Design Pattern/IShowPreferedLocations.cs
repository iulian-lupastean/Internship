namespace Behavioral_Design_Pattern

{
    public interface IShowPreferedLocations
    {
        IEnumerable<Location> ShowPreferedLocations(City city, IEnumerable<Location> locations);
    }
}
