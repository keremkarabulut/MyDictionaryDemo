using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1, "Adana");
            myDictionary.Add(2, "Adıyaman");
            myDictionary.Add(3, "Afyon");
            myDictionary.Add(4, "Ağrı");
            myDictionary.Add(5, "Amasya");
            myDictionary.Add(6, "Ankara");
        }
    }
}
