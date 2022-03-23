using LinqLesson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.ExtensionMethods
{
    public static class JoinsExtension
    {

        public static void JoinLaptopAndManufacturer(IEnumerable<Laptop> laptops, IEnumerable<Manufacturer> manufacturers)
        {

            var joinResult = laptops.Join(manufacturers,
                    laptop => laptop.ManufacturerID,
                    manufacturer => manufacturer.Id,
                    (laptop, manufacturer) => new
                    {
                        LaptopName = laptop.Name,
                        ManufacturerName = manufacturer.Name,
                    }

                );
            foreach (var item in joinResult)
            {
                Console.WriteLine(item);
            }
        }

        public static void JoinLaptopAndCEO(IEnumerable<Laptop> laptops, IEnumerable<Manufacturer> manufacturers)
        {

            var joinResult = laptops.Join(manufacturers,
                    laptop => laptop.ManufacturerID,
                    manufacturer => manufacturer.Id,
                    (laptop, manufacturer) => new
                    {
                        LaptopName = laptop.Name,
                        ManufacturerName = manufacturer.CEO,
                    }

                );
            foreach (var item in joinResult)
            {
                Console.WriteLine(item);
            }
        }

    }
}
