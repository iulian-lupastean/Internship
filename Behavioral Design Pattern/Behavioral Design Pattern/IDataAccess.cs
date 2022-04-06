namespace Behavioral_Design_Pattern
{
    public interface IDataAccess
    {
        void SaveData(string sql, Location location);
        public void open();
        public void close();

    }
}
