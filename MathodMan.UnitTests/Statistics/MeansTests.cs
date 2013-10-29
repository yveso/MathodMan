using MathodMan.Statistics;
using MathodMan.UnitTests.Statistics.TheoryClassData;
using System;
using System.Collections.Generic;
using Xunit;
using Xunit.Extensions;

namespace MathodMan.UnitTests.Statistics
{
    public class MeansTests
    {
        [Fact]
        public void Mode_DataIsNull_ThrowsArgumentNullException()
        {
            List<int> data = null;

            Assert.Throws<ArgumentNullException>(
                () => Means.Mode(data));
        }

        [Fact]
        public void Mode_DataIsEmpty_ThrowsArgumentException()
        {
            var data = new List<int>();

            Assert.Throws<ArgumentException>(
                () => Means.Mode(data));
        }

        [Theory, ClassData(typeof(ModeClassDataObject))]
        public void Mode_VariousStringInputs_ReturnsMode<T>(IEnumerable<T> data, IEnumerable<T> expected)
        {
            var result = Means.Mode(data);

            AssertMore.EqualInTermsOfSet(expected, result);
        }

        [Theory, ClassData(typeof(ModeClassDataInt))]
        public void Mode_VariousIntInputs_ReturnsMode(IEnumerable<int> data, IEnumerable<int> expected)
        {
            var result = Means.Mode(data);

            AssertMore.EqualInTermsOfSet(expected, result);
        }
    }
}
