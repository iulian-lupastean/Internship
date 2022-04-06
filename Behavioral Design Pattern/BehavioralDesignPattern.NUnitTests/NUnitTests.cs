using Behavioral_Design_Pattern;
using NUnit.Framework;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BehavioralDesignPattern.NUnitTests
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            ImportData importData = new ImportData();
            importData.open();
            Assert.AreEqual(importData.state(), ConnectionState.Open);
            importData.close();
        }

        [Test]
        [TestCase(1, "Museum", 2)]
        [TestCase(2, "Park", 1)]
        [TestCase(3, "Famous Building", 0)]
        public void ImportDataTest(int cityID, string type, int expected)
        {

            List<Location> locations = new List<Location>();
            ImportData importData = new ImportData();
            importData.open();
            locations = importData.readLocations();
            importData.close();
            var list = locations.Where(x => x.City_ID == cityID && x.Type == type).Select(x => x);
            int result = list.Count();
            Assert.AreEqual(expected, result);
        }
    }
}