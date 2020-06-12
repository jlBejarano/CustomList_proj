using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class MyList<T> : IEnumerable
    {
        private T[] items;
        int count;
        public int Count
        {
            get
            {
                return this.count;
            }
            set
            {
                this.count = value;
            }
        }
        int capacity;
        public int Capacity
        {
            get
            {
                return this.capacity;
            }
            set
            {
                this.capacity = value;
            }
        }

        public MyList()
        {
            Count = 0;
            Capacity = 4;
            items = new T[Capacity];
        }
        public void CheckCapacity()
        {
            if (Count >= Capacity)
            {
                Capacity = Capacity * 2;
                T[] tempArray = new T[Capacity];
                for (int i = 0; i < Count; i++)
                {
                    tempArray[i] = items[i];
                }
                items = tempArray;
            }
        }

        public void Add(T item)
        {
            CheckCapacity();
            items[Count] = item;
            Count++;
        }

        public override string ToString()
        {
            string userInput = "";
            if (Count > 0)
            {
                for (int i = 0; i < Count; i++)
                {
                    userInput = items[i].ToString() + "";
                }
            }
            return userInput;
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < items.Length; i++)
            {
                yield return items[i];
            }
        }

        public void Remove(T RemoveValue)
        {
            int removeItem = -1;
            for (int i = 0; i < Count; i++)
            {
                if (items[i].Equals(RemoveValue))
                {
                    removeItem = i;
                    break;
                }
            }

            if (removeItem >= 0)
            {
                for (int j = removeItem; j < Count; j++)
                {
                    if (Count - 1 != j)
                    {
                        items[j] = items[j + 1];
                    }
                }
                Count--;
            }
        }
    }
}
