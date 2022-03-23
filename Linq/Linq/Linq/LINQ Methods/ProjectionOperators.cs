using LinqLesson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.ProjectionOperators
{
    public static class ProjectionOperators
    {
        public static void SelectName(IEnumerable<Laptop> laptops)
        {
            var oneField = laptops.Select(x => x.Name);
            foreach (var item in oneField)
            {
                Console.WriteLine(item);
            }
        }
        public static void SelectMany(int[][] matrix)
        {
            IEnumerable<int> result = matrix.SelectMany(rows => rows.Distinct());
            foreach (var item in result)
            {
                Console.Write($"{item},");
            }
        }

    }
}
