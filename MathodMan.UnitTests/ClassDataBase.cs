using System.Collections.Generic;

namespace MathodMan.UnitTests
{
    abstract class ClassDataBase : IEnumerable<object[]>
    {
        private readonly List<object[]> _data;

        public ClassDataBase(List<object[]> data)
        {
            _data = data;
        }

        public IEnumerator<object[]> GetEnumerator()
        {
            return _data.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
