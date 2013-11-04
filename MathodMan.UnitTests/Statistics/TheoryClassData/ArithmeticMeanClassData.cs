using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MathodMan.UnitTests.Statistics.TheoryClassData
{
    class ArithmeticMeanClassDataInt : ClassDataBase
    {
        public ArithmeticMeanClassDataInt()
            : base(new List<object[]>
            {
                new object[] { new List<int> { 3 }, 3.0 },
                new object[] { new List<int> { 3, 11, 1 }, 5.0 },
                new object[] { new List<int> { 3, 10, 5, 7 }, 6.25 },
                new object[] { new List<int> { 3, 8, 9 }, 20.0 / 3.0 }
            })
        {
        }
    }

    class ArithmeticMeanClassDataDecimal : ClassDataBase
    {
        public ArithmeticMeanClassDataDecimal()
            : base(new List<object[]>
            {
                new object[] { new List<decimal> { 3 }, 3.0 },
                new object[] { new List<decimal> { 3, 11, 1 }, 5.0 },
                new object[] { new List<decimal> { 3, 10, 5, 7 }, 6.25 },
                new object[] { new List<decimal> { 3, 8, 9 }, 20.0 / 3.0 }
            })
        {
        }
    }

    class ArithmeticMeanClassDataDouble : ClassDataBase
    {
        public ArithmeticMeanClassDataDouble()
            : base(new List<object[]>
            {
                new object[] { new List<double> { 3 }, 3.0 },
                new object[] { new List<double> { 3, 11, 1 }, 5.0 },
                new object[] { new List<double> { 3, 10, 5, 7 }, 6.25 },
                new object[] { new List<double> { 3, 8, 9 }, 20.0 / 3.0 }
            })
        {
        }
    }
}
