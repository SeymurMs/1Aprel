using System;
using System.Collections.Generic;
using System.Text;

namespace Collection
{
    internal class MyList<T>
    {
        public T[] Arr = new T[0];

        public T this[int index]
        {
            get => Arr[index];

            set => Arr[index] = value;
        }

        public void Add(T val)
        {
            Array.Resize(ref Arr, Arr.Length + 1);
            Arr[Arr.Length - 1] = val;
        }
    }
}
