using System;
using System.Collections;
using System.Collections.Generic;

namespace Rextester
{
    class myStrings : IEnumerable<string>
    {
        public string[] str_arr = new string[] { "one", "two", "three", "four", "five" };

        public IEnumerator<string> GetEnumerator()
        {
            IEnumerator<string> r = new StringEnumerator(this);
            return r;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    class StringEnumerator : IEnumerator<string>
    {
        int index;
        myStrings sp;

        public StringEnumerator(myStrings str_obj)
        {
            index = -1;
            sp = str_obj;
        }

        object IEnumerator.Current
        {
            get
            { return sp.str_arr[index]; }
        }

        public string Current
        {
            get
            { return sp.str_arr[index]; }
        }

        public bool MoveNext()
        {
            if (index < sp.str_arr.Length - 1)
            {
                index++;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            index = -1;
        }

        public void Dispose()
        {
            // pass
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            myStrings spp = new myStrings();

            foreach (string i in spp)
                System.Console.WriteLine(i);
        }
    }
}