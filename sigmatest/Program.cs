using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace sigmatest
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello World!");
        }
    }

    public class MyList : IEnumerable
    {
        private readonly int[] items;
        MyList(params int[] _items)
        {
            items = _items;
        }

        public IEnumerable GetEnumerable() => items.GetEnumerator();
    }
}
