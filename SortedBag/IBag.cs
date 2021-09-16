using System.Collections;
using System.Collections.Generic;

namespace SortedBag
{
    public interface IBag
    {
        public void Add(int i);
        public void Remove();
        public int Size();
        public int GetLowest();
        public List<int> GetList();
    }
}