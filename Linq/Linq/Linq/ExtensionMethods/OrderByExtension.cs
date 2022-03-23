using LinqLesson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.ExtensionMethods
{
    public static class OrderByExtension
    {
        public static void OrderByFirstName(this IEnumerable<Laptop> laptops)
        {
            var orderByDiagonal = laptops.OrderBy(x => x.ScreenDiagonal).ToList();
            foreach (var item in orderByDiagonal)
            {
                Console.WriteLine(item);
            }

        }
        public static void OrderByLastName(this IEnumerable<Laptop> laptops)
        {
            var orderByRAM = laptops.OrderBy(x => x.RAM).ToList();
            foreach (var item in orderByRAM)
            {
                Console.WriteLine(item);
            }
        }
    }
}
