using LinqLesson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.Quantifiers
{
    public static class Quantifiers
    {
        public static void CheckIfContains(IEnumerable<Laptop> laptops, Laptop laptop)
        {
            var existsInList = (from pc in laptops select pc).Contains(laptop);
            Console.WriteLine($"{existsInList}");
        }

        public static bool MacBooksInStock(IEnumerable<Laptop> laptops)
        {
            return laptops.Any(x => x.Name.Contains("Apple"));
        }
        public static bool AllLaptopHasSSD(IEnumerable<Laptop> laptops)
        {
            return laptops.All(x => x.HasSSD == true);
        }


        public static void IsListEmpty(IEnumerable<Laptop> laptops)
        {
            if (laptops.SequenceEqual(Enumerable.Empty<Laptop>()))
            {
                Console.WriteLine("The List is Empty");
            }
            else
            {
                Console.WriteLine("The list is not empty!");
            }
        }
    }



}
