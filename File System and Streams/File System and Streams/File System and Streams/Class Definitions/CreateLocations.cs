using File_System_and_Streams.Abstractions;

namespace File_System_and_Streams.Class_Definitions
{
    public class CreateLocations : ICreateFile, ICreateFolder
    {
        public void CreateFolder(string path, string folderName)
        {
            var folderToBeCreatedPath = Path.Combine(path, folderName);
            if (!File.Exists(folderToBeCreatedPath))
            {
                Directory.CreateDirectory(folderToBeCreatedPath);
            }
        }

        public FileStream CreateFile(string path, string fileName)
        {
            var fileToBeCreatedPath = Path.Combine(path, fileName);
            return File.Create(fileToBeCreatedPath);
        }

        public void WriteInFile(FileStream fileStream)
        {
            using (StreamWriter writer = new StreamWriter(fileStream))
            {
                writer.WriteLine(new Location { Id = 1, Name = "Museum1", Address = "Museum1Address", Price = 14.99, LocationType = "Museum" });
                writer.WriteLine(new Location { Id = 2, Name = "Park1", Address = "Park1Address", Price = 0, LocationType = "Park" });
                writer.WriteLine(new Location { Id = 3, Name = "MemorialHouse1", Address = "MemorialHouse1Address", Price = 19.99, LocationType = "MemorialHouse" });
            }
        }



        public void ReadFromFile(FileStream fileStream)
        {
            string line = "";
            using (StreamReader reader = new StreamReader(fileStream))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
