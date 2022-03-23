using LinqLesson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.GenerationMethods
{
    public static class GenerationMethods
    {
        public static IEnumerable<Tablet> GenerateEmptyTabletList()
        {
            return Enumerable.Empty<Tablet>();
        }

        public static void RepeatStringNTimes(string str, int times)
        {
            IEnumerable<string> repeatedStringAsCollection = Enumerable.Repeat(str, times);
            foreach (var item in repeatedStringAsCollection)
            {
                Console.WriteLine(item);
            }
        }
        public static void Range(int start, int range)
        {
            var generateRange = Enumerable.Range(start, range);
            foreach (var item in generateRange)
            {
                Console.WriteLine(item);
            }
        }
    }
}
