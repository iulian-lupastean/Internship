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
        public static void OrderByFirstName(this IEnumerable<Student> student)
        {
            var orderByFirstName = student.OrderBy(x => x.FirstName).ToList();
            foreach (var item in orderByFirstName)
            {
                Console.WriteLine(item);
            }
            
        }
        public static void OrderByLastName(this IEnumerable<Student> student)
        {
            var orderByLastName = student.OrderBy(x => x.LastName).ToList();
            foreach (var item in orderByLastName)
            {
                Console.WriteLine(item);
            }
        }
    }
}
