using LinqLesson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    manufacturerName = manufacturer.Name,
                    laptopsName = laptop.Name,
                    specificRAM = laptop.RAM
                }).Where(x => x.specificRAM == 8 && x.manufacturerName == "ASUS").Select(x => x.laptopsName);
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

                });
            foreach (var item in groupJoin)
            {
                Console.WriteLine(item.manufacturer);
                foreach (var pc in item.laptopsAvailable)
                {
                    Console.WriteLine(pc.Name);
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
