namespace Behavioral_Design_Pattern
{
    public class ShowPreferedLocationsContext
    {
        private IShowPreferedLocations _strategy;
        public void SeeStrategy(IShowPreferedLocations strategy)
        {
            _strategy = strategy;
        }
        public void ShowPreferedLocations(City city, IEnumerable<Location> locations)
        {
            if (_strategy == null)
            {
                Console.WriteLine("No strategy Selected");
            }
            else
            {
                _strategy.ShowPreferedLocations(city, locations);
            }
        }
    }
}

