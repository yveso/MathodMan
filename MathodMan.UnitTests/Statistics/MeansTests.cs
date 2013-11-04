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

        [Theory, ClassData(typeof(ModeClassDataDouble))]
        public void Mode_VariousDoubleInputs_ReturnsMode(IEnumerable<double> data, IEnumerable<double> expected)
        {
            var result = Means.Mode(data);

            AssertMore.EqualInTermsOfSet(expected, result);
        }

        [Theory, ClassData(typeof(ModeClassDataDecimal))]
        public void Mode_VariousDecimalInputs_ReturnsMode(IEnumerable<decimal> data, IEnumerable<decimal> expected)
        {
            var result = Means.Mode(data);

            AssertMore.EqualInTermsOfSet(expected, result);
        }

        [Fact]
        public void Median_DataIsNull_ThrowsArgumentNullException()
        {
            List<int> data = null;

            Assert.Throws<ArgumentNullException>(
                () => Means.Median(data));
        }

        [Fact]
        public void Median_DataIsEmpty_ThrowsArgumentException()
        {
            var data = new List<int>();

            Assert.Throws<ArgumentException>(
                () => Means.Median(data));
        }

        [Theory, ClassData(typeof(MedianClassDataInt))]
        public void Median_VariousIntInputs_ReturnsMedian(IEnumerable<int> data, double expected)
        {
            var result = Means.Median(data);

            Assert.Equal(expected, result);
        }

        [Theory, ClassData(typeof(MedianClassDataDouble))]
        public void Median_VariousDoubleInputs_ReturnsMedian(IEnumerable<double> data, double expected)
        {
            var result = Means.Median(data);

            Assert.Equal(expected, result);
        }

        [Theory, ClassData(typeof(MedianClassDataDecimal))]
        public void Median_VariousDecimalInputs_ReturnsMedian(IEnumerable<decimal> data, double expected)
        {
            var result = Means.Median(data);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void ArithmeticMean_IntDataIsNull_ThrowsArgumentNullException()
        {
            List<int> data = null;

            Assert.Throws<ArgumentNullException>(
                () => Means.ArithmeticMean(data));
        }

        [Fact]
        public void ArithmeticMean_IntDataIsEmpty_ThrowsArgumentException()
        {
            var data = new List<int>();

            Assert.Throws<ArgumentException>(
                () => Means.ArithmeticMean(data));
        }

        [Theory, ClassData(typeof(ArithmeticMeanClassDataInt))]
        public void ArithmeticMean_VariousIntInputs_ReturnsArithmeticMean(IEnumerable<int> data, double expected)
        {
            var result = Means.ArithmeticMean(data);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void ArithmeticMean_DecimalDataIsNull_ThrowsArgumentNullException()
        {
            List<decimal> data = null;

            Assert.Throws<ArgumentNullException>(
                () => Means.ArithmeticMean(data));
        }

        [Fact]
        public void ArithmeticMean_DecimalDataIsEmpty_ThrowsArgumentException()
        {
            var data = new List<decimal>();

            Assert.Throws<ArgumentException>(
                () => Means.ArithmeticMean(data));
        }

        [Theory, ClassData(typeof(ArithmeticMeanClassDataDecimal))]
        public void ArithmeticMean_VariousDecimalInputs_ReturnsArithmeticMean(IEnumerable<decimal> data, double expected)
        {
            var result = Means.ArithmeticMean(data);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void ArithmeticMean_DoubleDataIsNull_ThrowsArgumentNullException()
        {
            List<double> data = null;

            Assert.Throws<ArgumentNullException>(
                () => Means.ArithmeticMean(data));
        }

        [Fact]
        public void ArithmeticMean_DoubleDataIsEmpty_ThrowsArgumentException()
        {
            var data = new List<double>();

            Assert.Throws<ArgumentException>(
                () => Means.ArithmeticMean(data));
        }

        [Theory, ClassData(typeof(ArithmeticMeanClassDataDouble))]
        public void ArithmeticMean_VariousDoubleInputs_ReturnsArithmeticMean(IEnumerable<double> data, double expected)
        {
            var result = Means.ArithmeticMean(data);

            Assert.Equal(expected, result);
        }
    }
}
