using System;
using System.Collections;
using System.Collections.Generic;

namespace SortedBag
{
    public class Bag : IBag
    {
        public readonly List<int> _bag = new List<int>();
        
        public void Add(int i)
        {
            _bag.Add(i);
        }

        public void Remove()
        {
            int lowest = Int32.MaxValue;
            foreach (int j in _bag)
            {
                if (j < lowest)
                {
                    lowest = j;
                }
            }

            _bag.Remove(lowest);
        }

        public int Size()
        {
            return _bag.Count;
        }

        public int GetLowest()
        {
            int lowest = Int32.MaxValue;
            foreach (int j in _bag)
            {
                if (j < lowest)
                {
                    lowest = j;
                }
            }

            return lowest;
        }

        public List<int> GetList()
        {
            return _bag;
        }

    }
}