using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Design_Pattern
{
    public class ShowParksFirst : IShowPreferedLocations
    {
        public IEnumerable<Location> ShowPreferedLocations(City city, IEnumerable<Location> locations)
        {
            var showLocations = locations
                .Where(x => x.City_ID.Equals(city.ID)).OrderByDescending(x => x.Type == "Park")
                .ThenBy(x => x.Type)
                .Select(x => x);
            return showLocations;
        }

    }
}
