using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1005
{
    class Generic1
    {
        static void Main()
        {
            List<PhoneInfo> list = new List<PhoneInfo>();
            list.Add(new PhoneInfo("홍길동"));
            list.Add(new PhoneInfo("김길동"));
            list.Add(new PhoneInfo("박길동"));
            list.Add(new PhoneInfo("이길동"));

            for(int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i].Name);
            }
            //List<int> list = new List<int>();
            //list.Add(10);
            //list.Add(20);

            //for(int i =0; i < list.Count; i++)
            //{
            //    Console.WriteLine(i);
            //}

        }
    }
    
}
