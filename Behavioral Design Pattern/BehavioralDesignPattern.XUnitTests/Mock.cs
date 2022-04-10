using Xunit;
using Moq;
using Autofac.Extras.Moq;
using AutoFixture;
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
                var fixture = new Fixture();
                var location = fixture.Build<Location>().Create();
                string sql = "INSERT INTO Locations(ID, Name,City_ID,Address,Price,Type) VALUES (ID,'Name',City_ID,'Address',Price,'Type')";

                mock.Mock<IDataAccess>().Setup(x => x.SaveData(sql, location));
                var cls = mock.Create<LocationProcessor>();
                cls.SaveLocation(location);
                mock.Mock<IDataAccess>().Verify(x => x.SaveData(sql, location), Times.Once);

            }

        }
    }
}