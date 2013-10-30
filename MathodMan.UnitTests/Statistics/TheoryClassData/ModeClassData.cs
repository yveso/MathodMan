using System.Collections.Generic;

namespace MathodMan.UnitTests.Statistics.TheoryClassData
{
    class ModeClassDataObject : ClassDataBase
    {
        public ModeClassDataObject()
            : base(new List<object[]>
            {
                new [] { new List<string> { "a" }, new List<string> { "a" } },
                new [] { new List<string> { "a", "b", "c" }, new List<string> { "a", "b", "c" } },
                new [] { new List<string> { "a", "b", "c", "a" }, new List<string> { "a" } },
                new [] { new List<string> { "a", "b", "c", "a", "c" }, new List<string> { "a", "c" } },
                new [] { new List<string> { "a", "b", "c", "a", "c" }, new List<string> { "c", "a" } }
            })
        {
        }
    }

    class ModeClassDataInt : ClassDataBase
    {
        public ModeClassDataInt()
            :base(new List<object[]> 
            {
                new [] { new List<int> { 4 }, new List<int> { 4 } },
                new [] { new List<int> { 4, 3, 7 }, new List<int> { 4, 3, 7 } },
                new [] { new List<int> { 4, 3, 7, 4, 4, 2, 7 }, new List<int> { 4 } },
                new [] { new List<int> { 4, 3, 7, 4, 4, 2, 7, 7 }, new List<int> { 4, 7 } },
                new [] { new List<int> { 4, 3, 7, 4, 4, 2, 7, 7 }, new List<int> { 7, 4 } }
            })
        {
        }
    }

    class ModeClassDataDouble : ClassDataBase
    {
        public ModeClassDataDouble()
            : base(new List<object[]> 
            {
                new [] { new List<double> { 3.7 }, new List<double> { 3.7 } },
                new [] { new List<double> { 3.7, 5.9, 11.654987 }, new List<double> { 3.7, 5.9, 11.654987 } },
                new [] { new List<double> { 3.7, 5.9, 11.654987, 3.7 }, new List<double> { 3.7 } },
                new [] { new List<double> { 3.7, 5.9, 11.654987, 3.7, 2.654123, 5.9 }, new List<double> { 3.7, 5.9 } },
                new [] { new List<double> { 3.7, 5.9, 11.654987, 3.7, 2.654123, 5.9 }, new List<double> { 5.9, 3.7 } }
            })
        {
        }
    }

    class ModeClassDataDecimal : ClassDataBase
    {
        public ModeClassDataDecimal()
            : base(new List<object[]> 
            {
                new [] { new List<decimal> { 3.7M }, new List<decimal> { 3.7M } },
                new [] { new List<decimal> { 3.7M, 5.9M, 11.654987M }, new List<decimal> { 3.7M, 5.9M, 11.654987M } },
                new [] { new List<decimal> { 3.7M, 5.9M, 11.654987M, 3.7M }, new List<decimal> { 3.7M } },
                new [] { new List<decimal> { 3.7M, 5.9M, 11.654987M, 3.7M, 2.654123M, 5.9M }, new List<decimal> { 3.7M, 5.9M } },
                new [] { new List<decimal> { 3.7M, 5.9M, 11.654987M, 3.7M, 2.654123M, 5.9M }, new List<decimal> { 5.9M, 3.7M } }
            })
        {
        }
    }
}
