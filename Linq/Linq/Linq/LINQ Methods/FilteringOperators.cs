using LinqLesson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.FilteringOperators
{
    public static class FilteringOperators
    {
        public static void SelectWhere(IEnumerable<Laptop> laptops)
        {
            var laptopsWithSSD = laptops.Where(laptops => laptops.HasSSD).Select(laptop => laptop.Name);
            Console.WriteLine("The following Laptops have SSD :");
            foreach (var item in laptopsWithSSD)
            {
                Console.WriteLine($" {item}");
            }

        }

        public static void TakeThenSkip(IEnumerable<Laptop> laptops)
        {
            var take = laptops.Take(5).Skip(2);
            Console.WriteLine("The Laptops in the interval [3,5] are :");
            foreach (var item in take)
            {
                Console.WriteLine($"{item}");
            }
        }

        public static void TakeLaptopsWhile(IEnumerable<Laptop> laptops)
        {
            var takeLaptopsWhile = laptops.TakeWhile(laptops => laptops.Capacity > 256);
            foreach (var item in takeLaptopsWhile)
            {
                Console.WriteLine($"{item}");
            }
        }

        public static void SkipLaptopsWhile(IEnumerable<Laptop> laptops)
        {
            var skipLaptopsWhile = laptops.TakeWhile(laptops => laptops.RAM > 16);
            foreach (var item in skipLaptopsWhile)
            {
                Console.WriteLine($"{item}");
            }
        }

        public static void Distinct(IEnumerable<Laptop> laptops)
        {
            var distinct = (from laptop in laptops select laptop.Name).Distinct();
            foreach (var item in distinct)
            {
                Console.WriteLine(item);
            }
        }


    }
}
