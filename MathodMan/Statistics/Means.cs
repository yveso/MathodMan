using MathodMan.Internals;
using System;
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

        public static double Median<T>(IEnumerable<T> data)
        {
            Sanitize.EnsureDataIsNotNullOrEmpty(data, "data");

            var orderedData = data.OrderBy(x => x);
            var elementCount = data.Count();

            if (elementCount % 2 == 1)
            {
                return Convert.ToDouble(orderedData.ElementAt((elementCount - 1) / 2));
            }
            else
            {
                var indexAboveMiddle = elementCount / 2;
                var elementAboveMiddle = Convert.ToDouble(orderedData.ElementAt(indexAboveMiddle));
                var elementBelowMiddle = Convert.ToDouble(orderedData.ElementAt(indexAboveMiddle - 1));

                return (elementBelowMiddle + elementAboveMiddle) / 2;
            }
        }
    }
}
