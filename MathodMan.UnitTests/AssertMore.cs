using System.Collections.Generic;
using System.Linq;
using Xunit;
using Xunit.Sdk;

namespace MathodMan.UnitTests
{
    class AssertMore
    {
        public static void EqualInTermsOfSet<T>(IEnumerable<T> expected, IEnumerable<T> actual)
        {
            try
            {
                Assert.Empty(actual.Except(expected));
                Assert.Empty(expected.Except(actual));
            }
            catch (EmptyException)
            {
                throw new AssertActualExpectedException(expected, actual, "Collections don't have the same elements");
            }
        }
    }
}
