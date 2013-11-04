using MathodMan.Arithmetics;
using System;
using Xunit;

namespace MathodMan.UnitTests.Arithmetics
{
    public class ArithmeticTest
    {
        [Fact]
        public void IsEven_NumberIsEven_ReturnsTrue()
        {
            var result = Arithmetic.IsEven(4);
            Assert.True(result);
        }

        [Fact]
        public void IsEven_NumberIsOdd_ReturnsFalse()
        {
            var result = Arithmetic.IsEven(5);
            Assert.False(result);
        }

        [Fact]
        public void IsOdd_NumberIsOdd_ReturnsTrue()
        {
            var result = Arithmetic.IsOdd(5);
            Assert.True(result);
        }

        [Fact]
        public void IsOdd_NumberIsEven_ReturnsFalse()
        {
            var result = Arithmetic.IsOdd(2);
            Assert.False(result);
        }

        [Fact]
        public void GreatestCommonDivisor_NumbersAreCoprime_ReturnsOne()
        {
            var result = Arithmetic.GreatestCommonDivisor(3, 5);
            Assert.Equal(1, result);
        }

        [Fact]
        public void GreatestCommonDivisor_AIsDivisorOfB_ReturnsA()
        {
            var result = Arithmetic.GreatestCommonDivisor(4, 16);
            Assert.Equal(4, result);
        }

        [Fact]
        public void GreatestCommonDivisor_NumbersHaveGcd_ReturnsThatGcd()
        {
            int a = 6, b = 8;

            var result = Arithmetic.GreatestCommonDivisor(a, b);
            
            Assert.Equal(2, result);
        }

        [Fact]
        public void GreatestCommonDivisor_BothNumbersAreNotZero_OrderOfArgumentsDoesNotMatter()
        {
            int a = 6, b = 8;

            var resultAB = Arithmetic.GreatestCommonDivisor(a, b);
            var resultBA = Arithmetic.GreatestCommonDivisor(b, a);

            Assert.Equal(resultAB, resultBA);
        }

        [Fact]
        public void GreatestCommonDivisor_BothNumbersAreZero_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(
                () => Arithmetic.GreatestCommonDivisor(0, 0));
        }

        [Fact]
        public void GreatestCommonDivisor_AIsZeroBIsGreaterZero_ReturnsB()
        {
            var result = Arithmetic.GreatestCommonDivisor(0, 5);
            Assert.Equal(5, result);
        }

        [Fact]
        public void GreatestCommonDivisor_AIsZeroBIsLessZero_ReturnsAbsB()
        {
            var result = Arithmetic.GreatestCommonDivisor(0, -5);
            Assert.Equal(5, result);
        }

        [Fact]
        public void GreatestCommonDivisor_AIsGreaterZeroBIsZero_ReturnsA()
        {
            var result = Arithmetic.GreatestCommonDivisor(5, 0);
            Assert.Equal(5, result);
        }

        [Fact]
        public void GreatestCommonDivisor_AIsLessZeroBIsZero_ReturnsAbsaA()
        {
            var result = Arithmetic.GreatestCommonDivisor(-3, 0);
            Assert.Equal(3, result);
        }

        [Fact]
        public void LeastCommonMultiple_BothNumbersHaveALcm_ReturnsThatLcm()
        {
            var result = Arithmetic.LeastCommonMultiple(6, 4);
            Assert.Equal(12, result);
        }

        [Fact]
        public void LeastCommonMultiple_BothNumbersAreCoprime_ReturnsProduct()
        {
            var result = Arithmetic.LeastCommonMultiple(3, 5);
            Assert.Equal(15, result);
        }

        [Fact]
        public void LeastCommonMultiple_AIsDivsorOfB_ReturnsB()
        {
            var result = Arithmetic.LeastCommonMultiple(3, 9);
            Assert.Equal(9, result);
        }

        [Fact]
        public void LeastCommonMultiple_BothNumbersAreNotZero_OrderOfArgumentsDoesNotMatter()
        {
            int a = 4, b = 10;

            var resultAB = Arithmetic.LeastCommonMultiple(a, b);
            var resultBA = Arithmetic.LeastCommonMultiple(b, a);

            Assert.Equal(resultAB, resultBA);
        }

        [Fact]
        public void LeastCommonMultiple_BothNumbersAreZero_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(
                () => Arithmetic.LeastCommonMultiple(0, 0));
        }

        [Fact]
        public void LeastCommonMultiple_AIsZeroBIsGreaterZero_ReturnsB()
        {
            var result = Arithmetic.LeastCommonMultiple(0, 6);
            Assert.Equal(6, result);
        }

        [Fact]
        public void LeastCommonMultiple_AIsZero_BIsLessZero_ReturnsAbsB()
        {
            var result = Arithmetic.LeastCommonMultiple(0, -6);
            Assert.Equal(6, result);
        }

        [Fact]
        public void LeastCommonMultiple_AIsGreaterZeroBIsZero_ReturnsA()
        {
            var result = Arithmetic.LeastCommonMultiple(4, 0);
            Assert.Equal(4, result);
        }

        [Fact]
        public void LeastCommonMultiple_AIsLessZeroBIsZero_ReturnsAbsA()
        {
            var result = Arithmetic.LeastCommonMultiple(-4, 0);
            Assert.Equal(4, result);
        }
    }
}
