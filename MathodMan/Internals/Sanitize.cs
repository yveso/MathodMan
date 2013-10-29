using System;
using System.Collections.Generic;
using System.Linq;

namespace MathodMan.Internals
{
    internal static class Sanitize
    {
        public static void EnsureDataIsNotNullOrEmpty<T>(IEnumerable<T> data, string name)
        {
            if (data == null)
            {
                throw new ArgumentNullException(name);
            }
            if (data.Count() == 0)
            {
                throw new ArgumentException(name + " cannot be empty", name);
            }
        }
    }
}
