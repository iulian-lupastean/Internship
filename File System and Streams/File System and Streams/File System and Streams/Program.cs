using File_System_and_Streams.Class_Definitions;

namespace File_System_and_Streams
{
    public class Program
    {
        static void Main(string[] args)
        {
            string currentPath = Directory.GetCurrentDirectory();
            CreateLocations createLocations = new CreateLocations();
            createLocations.CreateFolder(currentPath, "Locations");
            string path = Path.Combine(currentPath, "Locations");
            FileStream fileStream = createLocations.CreateFile(path, "locations.txt");
            createLocations.WriteInFile(fileStream);
            createLocations.ReadFromFile(fileStream);
        }
    }
}

