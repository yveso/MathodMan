using System.Collections.Generic;

namespace MathodMan.UnitTests.Statistics.TheoryClassData
{
    class ModeClassDataObject : ClassDataBase
    {
        public ModeClassDataObject()
            : base(new List<object[]>
            {
                new object[] { new List<string> { "a" }, new List<string> { "a" } },
                new object[] { new List<string> { "a", "b", "c" }, new List<string> { "a", "b", "c" } },
                new object[] { new List<string> { "a", "b", "c", "a" }, new List<string> { "a" } },
                new object[] { new List<string> { "a", "b", "c", "a", "c" }, new List<string> { "a", "c" } },
                new object[] { new List<string> { "a", "b", "c", "a", "c" }, new List<string> { "c", "a" } }
            })
        {
        }
    }

    class ModeClassDataInt : ClassDataBase
    {
        public ModeClassDataInt()
            :base(new List<object[]> 
            {
                new object[] { new List<int> { 4 }, new List<int> { 4 } },
                new object[] { new List<int> { 4, 3, 7 }, new List<int> { 4, 3, 7 } },
                new object[] { new List<int> { 4, 3, 7, 4, 4, 2, 7 }, new List<int> { 4 } },
                new object[] { new List<int> { 4, 3, 7, 4, 4, 2, 7, 7 }, new List<int> { 4, 7 } },
                new object[] { new List<int> { 4, 3, 7, 4, 4, 2, 7, 7 }, new List<int> { 7, 4 } }
            })
        {
        }
    }
}
