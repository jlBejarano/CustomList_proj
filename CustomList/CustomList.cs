using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class MyList<T>
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
    }
}
