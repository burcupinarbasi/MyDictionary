using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int,string> myDictionary = new MyDictionary<int,string>();

            myDictionary.Add(123, "Burcu");
            myDictionary.Add(124, "Ayse");
            myDictionary.Add(125, "Bahar");
            myDictionary.Add(126, "Cansu");


            int sayi = myDictionary.Count;
            Console.WriteLine("eleman sayisi"+sayi);

        }
    }
}
