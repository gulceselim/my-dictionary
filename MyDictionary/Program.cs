using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> users1 = new MyDictionary<int, string>();
            users1.Add(1, "Selim");
            users1.Add(1, "Emre");
            users1.Add(2, "Mehmet");


            users1.GetDictionary();
        }
    }
}
