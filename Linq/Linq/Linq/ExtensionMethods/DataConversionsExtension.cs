using LinqLesson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.ExtensionMethods
{
   public static class DataConversionsExtension
    {
        public static Dictionary<string,string> ConvertToDictionaryWithID(this IEnumerable<Faculty> faculty)
        {
            return faculty.ToDictionary(x => x.Id, x => x.Name);
        }
        public static Dictionary<string, string> ConvertToDictionaryWithHeadMaster(this IEnumerable<Faculty> faculty)
        {
            return faculty.ToDictionary(x => x.Name, x => x.HeadMaster);
        }

    }
}
