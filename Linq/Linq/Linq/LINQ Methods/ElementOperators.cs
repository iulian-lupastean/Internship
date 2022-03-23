using LinqLesson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.ElementOperators
{
    public static class ElementOperators
    {
        //The program crashes if we use First Instead of FirstOrDefault if there is no match in the list
        public static void FirstOrDefault(IEnumerable<Laptop> laptops)
        {
            Console.WriteLine("First element in list is {0}", laptops.FirstOrDefault(x => x.Name.Contains("Dell")));
        }
        public static void LastOrDefault(IEnumerable<Laptop> laptops)
        {
            Console.WriteLine("Last element in list is {0}", laptops.LastOrDefault(x => x.Name.Contains("Dell")));
        }
        public static void SingleOrDefault(IEnumerable<Laptop> laptops)
        {
            Console.WriteLine("The only Apple Product is {0}", laptops.SingleOrDefault(x => x.Name.Contains("ASUS")));
        }

        public static void ElementAtOrDefault(IEnumerable<Laptop> laptops)
        {
            Console.WriteLine("The element at position 5 is: {0}", laptops.ElementAtOrDefault(5));
        }

        // if the List is empty it returns a default value 
        public static void DefautIfEmpty(IEnumerable<Laptop> laptops)
        {
            var defaultIfEmpty = laptops.DefaultIfEmpty();
            foreach (var item in defaultIfEmpty)
            {
                Console.WriteLine(item);
            }

        }

    }
}
