using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1005
{
    class HashSet1
    {
        static void Main()
        {
            HashSet<int> lotto = new HashSet<int>();
            Random rnd = new Random();

            while (true)
            {
                lotto.Add(rnd.Next(1,47));

                if (lotto.Count > 6)
                    break;
            }

            int[] a_lotto = lotto.ToArray<int>();
            Array.Sort(a_lotto);

            foreach(int temp in lotto)
            {
                Console.Write(temp + ",");
            }
        }
    }
}
