using LinqLesson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.SetOperators
{
    public static class SetOperators
    {
        public static void ConcatenateLists(IEnumerable<Laptop> laptops, IEnumerable<Laptop> onSale)
        {
            var result = laptops.Concat(onSale);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        public static void UniteLists(IEnumerable<Laptop> laptops, IEnumerable<Laptop> onSale)

        {
            var result = laptops.Union(onSale);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        public static void OnSaleRemainingStock(IEnumerable<Laptop> laptops, IEnumerable<Laptop> onSale)
        {
            var result = onSale.Intersect(laptops);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        public static void OnSaleOutofStock(IEnumerable<Laptop> laptops, IEnumerable<Laptop> onSale)
        {
            var result = onSale.Except(laptops);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
