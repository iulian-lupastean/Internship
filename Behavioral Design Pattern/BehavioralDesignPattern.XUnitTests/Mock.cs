using Xunit;
using Moq;
using Autofac.Extras.Moq;
using Behavioral_Design_Pattern;

namespace BehavioralDesignPattern.XUnitTests
{
    public class Mock
    {
        [Fact]
        public void InsertLocation_ValidCall()
        {

            using (var mock = AutoMock.GetLoose())
            {
                var location = new Location
                {
                    ID = 125,
                    Name = "Park3Madrid",
                    City_ID = 1,
                    Address = "Addresspark2Madrid",
                    Price = 0,
                    Type = "Park"
                };
                string sql = "INSERT INTO Locations(ID, Name,City_ID,Address,Price,Type) VALUES (ID,'Name',City_ID,'Address',Price,'Type')";

                mock.Mock<IDataAccess>().Setup(x => x.SaveData(sql, location));
                var cls = mock.Create<LocationProcessor>();
                cls.SaveLocation(location);
                mock.Mock<IDataAccess>().Verify(x => x.SaveData(sql, location), Times.Once);

            }

        }
    }
}