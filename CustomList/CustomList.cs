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
        string stringOfLists;
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

        public T this[int index] 
        {
            get
            {
                if (Count == 0 || index >= Count)
                {
                    throw new IndexOutOfRangeException("Out of range");
                }
                else
                {
                    return items[index];
                }
            }
            set
            {
                if (Count == 0 || index >= Count)
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    items[index] = value;
                }
            }
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

        public static MyList<T> operator +(MyList<T>l1, MyList<T>l2)
        {
            MyList<T> combinedList = new MyList<T>();
            for (int i = 0; i < l1.Count; i++)
            {
                combinedList.Add(l1[i]);
            }

            for (int i = 0; i < l2.Count; i++)
            {
                combinedList.Add(l2[i]);
            }
            return combinedList;
        }

        public static MyList<T> operator -(MyList<T> l1, MyList<T> l2)
        {
            MyList<T> newList = new MyList<T>();
            for (int i = 0; i < l1.Count; i++)
            {
                newList.Add(l1[i]);
            }

            for (int i = 0; i < newList.Count; i++)
            {
                for (int j = 0; j <l2.Count; j++)
                {
                    if (newList[i].Equals(l2[j]))
                    {
                        newList.Remove(l2[j]);
                    }
                }
            }

            return newList;
        }

        public MyList<T> Zip(MyList<T> list)
        {
            MyList<T> temp1 = new MyList<T>();
            MyList<T> temp2 = new MyList<T>();
            for (int i = 0; i <list.Count; i++)
            {
                temp1.Add(list[i]);
            }
            for (int i = 0; i < list.Length; i++)
            {
                temp2.Add(list[i]);
            }
            MyList<T> zipList = new MyList<T>();
            int maxCount;
            if (temp1.Count > temp2.Count)
            {
                maxCount = temp1.Count;
            }
            else
            {
                maxCount = temp2.Count;
            }
            for (int i = 0; i < maxCount; i++)
            {
                if (i < temp2.Count)
                {
                    zipList.Add(temp2[i]);
                }
                if (i < temp1.Count)
                {
                    zipList.Add(temp1[i]);
                }

            
            }
            return zipList;
        }
    }
}
