using LinqLesson;
namespace Linq.Joins
{
    public static class Joins
    {
        public static void AvailableLaptopsFromManufacturers(IEnumerable<Laptop> laptops, IEnumerable<Manufacturer> manufacturers)
        {
            var innerJoin = laptops.Join(manufacturers,
                laptop => laptop.ManufacturerID,
                manufacturer => manufacturer.Id,
                (laptop, manufacturer) => new
                {
                    laptopName = laptop.Name,
                    manufacturerName = manufacturer.Name,
                    laptopRAM = laptop.RAM
                }).Where(x => x.laptopRAM == 8 && x.manufacturerName.Equals("ASUS")).Select(x => x.laptopName);
            foreach (var item in innerJoin)
            {
                Console.WriteLine(item);
            }
        }
        public static void AvailableLaptopsFromManufacturersByID(IEnumerable<Laptop> laptops, IEnumerable<Manufacturer> manufacturers)
        {
            var groupJoin = manufacturers.GroupJoin(laptops,
                manufacturer => manufacturer.Id,
                laptop => laptop.ManufacturerID,

                (manufacturer, laptop) => new
                {
                    laptopsAvailable = laptop,
                    manufacturer = manufacturer.Name,

                }));
            foreach (var item in groupJoin)
            {
                foreach (var pc in item)
                {
                    Console.WriteLine(pc.Price);
                }
            }


        }
        public static void Zipp(string[] str, int[] num)
        {
            var conversion = num.Zip(str,
                (first, second) => first + " -> " + second);
            foreach (var item in conversion)
            {
                Console.WriteLine(item);
            }
        }
    }
}
