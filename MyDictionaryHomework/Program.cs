using System;
using System.Collections.Generic;

namespace MyDictionaryHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> Liste = new MyDictionary<string, int>();
            Liste.Add("Büşra", 25);
            Liste.Add("Cahit", 30);
            Liste.Add("Bekir", 62);
            Liste.Add("Pınar", 27);
            Liste.Add("Halime", 56);

            Liste.List();

            
           
            

        }
    }
}
