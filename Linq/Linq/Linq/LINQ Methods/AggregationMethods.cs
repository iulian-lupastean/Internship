using LinqLesson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.AggregationMethods
{
    public static class AggregationMethods
    {
        public static void CountLaptopsWithSSD(IEnumerable<Laptop> laptops)
        {
            int count = laptops.Count(x => x.HasSSD == true);
            Console.WriteLine($"There are {count} laptops that have SSD.");
        }
        public static void MaxDiagonalLength(IEnumerable<Laptop> laptops)
        {
            double maxDiagonal = laptops.Max(x => x.ScreenDiagonal);
            Console.WriteLine($"The max diagonal a laptop in our stock has is {maxDiagonal} inches");
        }

        public static void AveragePrice(IEnumerable<Laptop> laptops)
        {
            Console.WriteLine($"The average price for our laptops is {laptops.Average(x => x.Price)}");
        }

        public static void AllManufacturers(IEnumerable<Manufacturer> manufacturers)
        {
            string StockWorth = manufacturers.Aggregate("", (a, b) => a + b.Name + ",");
            Console.WriteLine($"The list of manufacturers: {StockWorth}");
        }
    }
}
