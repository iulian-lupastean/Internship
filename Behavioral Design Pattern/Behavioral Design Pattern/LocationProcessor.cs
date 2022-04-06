namespace Behavioral_Design_Pattern
{
    public class LocationProcessor
    {
        IDataAccess _ImportData;
        public LocationProcessor(IDataAccess ImportData)
        {
            _ImportData = ImportData;
        }
        public void SaveLocation(Location location)
        {
            string sql = "INSERT INTO Locations(ID, Name,City_ID,Address,Price,Type) VALUES (ID,'Name',City_ID,'Address',Price,'Type')";
            _ImportData.SaveData(sql, location);
        }
    }
}
