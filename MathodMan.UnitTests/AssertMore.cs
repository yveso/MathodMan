using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace MathodMan.UnitTests
{
    class AssertMore
    {
        public static void EqualInTermsOfSet<T>(IEnumerable<T> expected, IEnumerable<T> actual)
        {
            //TODO: More speaking failure
            Assert.Empty(actual.Except(expected));
            Assert.Empty(expected.Except(actual));
        }
    }
}
