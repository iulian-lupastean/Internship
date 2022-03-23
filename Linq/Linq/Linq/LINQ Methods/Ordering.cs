using LinqLesson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.Ordering
{
    public static class Ordering
    {
        public static void OrderByCapacityThenByRAMAsc(IEnumerable<Laptop> laptops)
        {
            var orderASC = laptops.OrderBy(x => x.Capacity).ThenBy(y => y.RAM);
            foreach (var item in orderASC)
            {
                Console.WriteLine(item);
            }
        }

        public static IEnumerable<Laptop> OrderByPriceThenByFrequencyDesc(IEnumerable<Laptop> laptops)
        {
            return laptops.OrderByDescending(x => x.Price).ThenByDescending(y => y.ProcesorFrequency);

        }
        public static IEnumerable<Laptop> ReversedList(IEnumerable<Laptop> laptops)
        {
            return laptops.Reverse();

        }
    }
}
