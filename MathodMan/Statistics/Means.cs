using MathodMan.Internals;
using System.Collections.Generic;
using System.Linq;

namespace MathodMan.Statistics
{
    public class Means
    {
        public static IEnumerable<T> Mode<T>(IEnumerable<T> data)
        {
            Sanitize.EnsureDataIsNotNullOrEmpty(data, "data");

            var dataWithCount =
                data
                .GroupBy(x => x)
                .Select(x => new { Object = x.Key, Count = x.Count() });

            var result =
                from item in dataWithCount
                let mostFrequentCount = dataWithCount.Max(x => x.Count)
                where item.Count == mostFrequentCount
                select item.Object;

            return result;
        }
    }
}
