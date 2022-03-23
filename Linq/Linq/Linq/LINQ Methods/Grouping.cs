using LinqLesson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.Grouping
{
    public static class Grouping
    {
        public static void GroupByCapacity(IEnumerable<Laptop> laptops)
        {
            var group = laptops.GroupBy(x => x.Capacity).OrderBy(x => x.Key);
            foreach (var subgroup in group)
            {
                Console.WriteLine($"Capacity of {subgroup.Key} GB");
                foreach (var item in subgroup)
                {
                    Console.WriteLine(item.Name);
                }
            }
        }

    }
}
