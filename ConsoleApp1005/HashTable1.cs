using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1005
{
    class HashTable1
    {
       static void Main()
        {
            SortedList ht = new SortedList();
            ht.Add("홍길동", 25);
            ht.Add("김길동", 25);
            ht.Add("박길동", 35);
            ht.Add("이길동", 40);

            if (! ht.ContainsKey("이길동"))
                ht.Add("이길동", 40);

            int age = (int)ht["박길동"];
            Console.WriteLine(age);

            foreach(string key in ht.Keys)
            {
                Console.WriteLine($"{key} - {ht[key]}");
            }
        }
    }
}
