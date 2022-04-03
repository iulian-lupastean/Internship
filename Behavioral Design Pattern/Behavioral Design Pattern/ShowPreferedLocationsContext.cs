namespace Behavioral_Design_Pattern
{
    public class ShowPreferedLocationsContext
    {
        private IShowPreferedLocations _strategy;
        public void SeeStrategy(IShowPreferedLocations strategy)
        {
            _strategy = strategy;
        }
        public IEnumerable<Location> ShowPreferedLocations(City city, IEnumerable<Location> locations)
        {
            if (_strategy == null)
            {
                return null;
            }
            else
            {
                return _strategy.ShowPreferedLocations(city, locations);
            }
        }
    }
}

