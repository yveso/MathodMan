using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MathodMan.UnitTests.Statistics.TheoryClassData
{
    class MedianClassDataInt : ClassDataBase
    {
        public MedianClassDataInt()
            : base(new List<object[]> 
            {
                new object[] { new List<int> { 4 }, 4.0 },
                new object[] { new List<int> { 4, 3, 4 }, 4.0 },
                new object[] { new List<int> { 4, 1, 12, 23, 5 }, 5.0 },
                new object[] { new List<int> { 4, 1, 12, 23, 5, 6 }, 5.5 }
            })
        {
        }
    }

    class MedianClassDataDouble : ClassDataBase
    {
        public MedianClassDataDouble()
            : base(new List<object[]> 
            {
                new object[] { new List<double> { 4.0 }, 4.0 },
                new object[] { new List<double> { 4.7, 3.1, 4.7 }, 4.7 },
                new object[] { new List<double> { 4.5, 1.6, 18.654, 23.1111, 5.12345 }, 5.12345 },
                new object[] { new List<double> { 4.236, 1.125, 12.257, 23.2, 5.5, 6 }, 5.75 }
            })
        {
        }
    }

    class MedianClassDataDecimal : ClassDataBase
    {
        public MedianClassDataDecimal()
            : base(new List<object[]> 
            {
                new object[] { new List<decimal> { 4.0M }, 4.0 },
                new object[] { new List<decimal> { 4.7M, 3.1M, 4.7M }, 4.7 },
                new object[] { new List<decimal> { 4.5M, 1.6M, 18.654M, 23.1111M, 5.12345M }, 5.12345 },
                new object[] { new List<decimal> { 4.236M, 1.125M, 12.257M, 23.2M, 5.5M, 6.0M }, 5.75 }
            })
        {
        }
    }
}
