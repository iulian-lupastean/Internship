using LinqLesson;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.ConversionMethods
{
    public static class ConversionMethods
    {
        public static void GetMacBooks(IEnumerable<Laptop> laptops)
        {
            var MacBooks = laptops.OfType<MacBook>();
            foreach (var MacBook in MacBooks)
            {
                Console.WriteLine(MacBook);
            }
        }
        public static void CastToList(IEnumerable<Laptop> laptops)
        {
            var laptopsAsList = laptops.Cast<Laptop>().ToList();
            foreach (var item in laptopsAsList)
            {
                Console.WriteLine(item);
            }

        }

        public static void CastAsArray(IEnumerable<Manufacturer> manufacturers)
        {
            Manufacturer[] manufacturersAsArray = manufacturers.Cast<Manufacturer>().ToArray();
            foreach (var item in manufacturersAsArray)
            {
                Console.WriteLine(item.Name);
            }
        }

        public static void ConvertToDictionary(IEnumerable<Manufacturer> manufacturers)
        {
            var manufacturerDictionary = manufacturers.ToDictionary(manufacturer => manufacturer.Id, manufacturer => manufacturer.Name);
            foreach (var item in manufacturerDictionary)
            {
                Console.WriteLine(item);
            }
        }

        public static void ConvertToLookUp(IEnumerable<Laptop> laptops)
        {
            ILookup<int, Laptop> lookUp = laptops.ToLookup(s => s.Capacity);
            IEnumerable<Laptop> filtered = lookUp[256];
            foreach (var item in filtered)
            {
                Console.WriteLine(item);
            }
        }
        public static void ConvertToAsEnumerable(int[] array)
        {
            var result = array.AsEnumerable();
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
        public static void ConvertToAsQueryable(IEnumerable<Laptop> laptop)
        {
            var query = laptop.AsQueryable().Where(laptop => laptop.Name.Contains("ASUS"));

            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
        }
    }


}
