using Behavioral_Design_Pattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace BehavioralDesignPattern.MSUnitTests
{
    [TestClass]
    public class BehavioralDesignPatternTests
    {
        class Show_Parks_First
        {
            public IEnumerable<Location> _locations = new List<Location>
            {
                new Location {ID=101, Name="Muzeu1Madrid",City_ID=1,Address="AdresaMuzeu1Madrid",Price=19.99,Type="Museum"},
                new Location {ID=103, Name="Parc1Madrid",City_ID=1,Address="Av. de Ramón y Cajal, 2, 28016 Madrid, Spania",Price=19.99,Type="Park"},
                new Location {ID=105, Name="Cladire1Madrid",City_ID=1,Address="Pl. de Colón, 28001 Madrid, Spania",Price=19.99,Type="Famous Building"},
            };
            public IEnumerable<City> _cities = new List<City> {
            new City {ID=1, Name="Madrid"},
            };

        }
        [TestMethod]
        public void FirstElementInList_IsPark()
        {
            //Arrange
            Show_Parks_First data = new Show_Parks_First();
            var context = new ShowParksFirst();
            //Act
            var newList = context.ShowPreferedLocations(data._cities.First(), data._locations.Where(x => x.City_ID == data._cities.First().ID).Select(x => x));
            //Assert
            Assert.AreEqual(newList.First(), new Location { ID = 103, Name = "Parc1Madrid", City_ID = 1, Address = "Av. de Ramón y Cajal, 2, 28016 Madrid, Spania", Price = 19.99, Type = "Park" });
        }
        [TestMethod]
        public void FirstElementInList_IsMuseum()
        {
            //Arrange
            Show_Parks_First data = new Show_Parks_First();
            var context = new ShowMuseumsFirst();
            //Act
            var newList = context.ShowPreferedLocations(data._cities.First(), data._locations.Where(x => x.City_ID == data._cities.First().ID).Select(x => x));
            //Assert
            Assert.AreEqual(newList.First(), new Location { ID = 101, Name = "Muzeu1Madrid", City_ID = 1, Address = "AdresaMuzeu1Madrid", Price = 19.99, Type = "Museum" });

        }
        [TestMethod]
        public void FirstElementInList_IsFamousBuildings()
        {
            //Arrange
            Show_Parks_First data = new Show_Parks_First();
            var context = new ShowFamousBuildingFirst();
            //Act
            var newList = context.ShowPreferedLocations(data._cities.First(), data._locations.Where(x => x.City_ID == data._cities.First().ID).Select(x => x));
            //Assert
            Assert.AreEqual(newList.First(), new Location { ID = 105, Name = "Cladire1Madrid", City_ID = 1, Address = "Pl. de Colón, 28001 Madrid, Spania", Price = 19.99, Type = "Famous Building" });

        }
    }
}