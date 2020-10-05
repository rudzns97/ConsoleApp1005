using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1005
{
    class List1
    {
        static void Main()
        {
            List<string> list = new List<string>();

            list.Add("김치찌개");
            list.Add("된장찌개");
            list.Add("순두부찌개");
            list.Add("동태찌개");
            list.Add("부대찌개");

            foreach(string item in list)
            {

            }
            list.Sort();
            list.Reverse();

            string[] arr = list.ToArray();
            int[] strArr = new int[3] {10,20,30 };
            strArr.ToList<int>();
            for(int i=0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}
