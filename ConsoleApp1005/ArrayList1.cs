using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1005
{
    class ArrayList1
    {
        static void Main()
        {
            PhoneInfo info = new PhoneInfo();
            info.Name = "홍길동";
            info.Phone = "010-1111-1111";

            ArrayList alist = new ArrayList();
            alist.Add("사과");
            alist.Add("사과");
            alist.Add("딸기");
            alist.Add("참외");
            alist.Add("수박");
            alist.Add(123);
            alist.Add(info);
            alist.Insert(0,"포도");

            Console.WriteLine(alist.Count);

            if(alist.Count > 12)
            {

            }

            alist.Remove("딸기");
            Console.WriteLine(alist.Count);
            for (int i = 0; i < alist.Count; i++)
            {
                if (alist[i] is PhoneInfo)
                {
                    Console.WriteLine(((PhoneInfo)alist[i]).Name);
                }
                else
                {
                    Console.WriteLine(alist[i]);
                }

            }
        }
        public class PhoneInfo
        {
            public string Name { get; set; }
            public string Phone { get; set; }
            public string Birth { get; set; }
        }
    }
}
