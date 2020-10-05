using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1005
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            //5명의 이름을 입력받고, 5명의 이름을 출력해보세요.
            string[] nameArr = new string[5];
            for (int i = 0; i < nameArr.Length; i++)
            {
                nameArr[i] = Console.ReadLine();
            }
            foreach (string name in nameArr)
            {
                Console.WriteLine(name);
            }
            //5명의 이름과 전화번호를 입력받아서, 출력해보세요.
            string[,] personArr = new string[5, 2];
            for (int i = 0; i < personArr.GetLength(0); i++)
            {
                Console.Write("이름: ");
                personArr[i, 0] = Console.ReadLine();

                Console.Write("전화번호: ");
                personArr[i, 1] = Console.ReadLine();
            }
            for (int i = 0; i < personArr.GetLength(0); i++)
            {
                Console.WriteLine($"{personArr[i, 0]}님의 전화번호는 {personArr[i, 1]}입니다");
            }

            //5명의 이름, 전화번호, 생일을 입력받아서, 출력해보세요
            PhoneInfo[] pArr = new PhoneInfo[5];
            for (int i = 0; i < pArr.Length; i++)
            {
                PhoneInfo info = new PhoneInfo();

                Console.WriteLine("이름: ");
                info.Name = Console.ReadLine();

                Console.WriteLine("전화번호: ");
                info.Phone = Console.ReadLine();

                Console.WriteLine("생일: ");
                info.Birth = Console.ReadLine();

                pArr[i] = info;
            }
            foreach (PhoneInfo info in pArr)
            {
                Console.WriteLine($"{info.Name}, {info.Phone}, {info.Birth}");
            }
            #endregion

            //입력하는대로 이름, 전화번호, 생일을 모두 저장했다가, 출력해보세요.
            //Console.WriteLine("몇 명까지 입력하실겁니까?");
            //int Cnt = int.Parse(Console.ReadLine());
            //PhoneInfo[] pArr2 = new PhoneInfo[Cnt];

            ArrayList alist = new ArrayList();
            while (true)
            {
                PhoneInfo info = new PhoneInfo();
                Console.Write("이름: ");
                info.Name = Console.ReadLine();

                Console.Write("전화번호: ");
                info.Phone = Console.ReadLine();

                Console.Write("생일: ");
                info.Birth = Console.ReadLine();

                alist.Add(info);
                //alist.Add(100);
                Console.Write("계속(y), 종료(q)");
                if (Console.ReadLine().ToUpper() == "Q")
                    break;
            }
            foreach (PhoneInfo info in alist)
            {
                Console.WriteLine($"{info.Name} {info.Phone} {info.Birth}");
            }

            List<PhoneInfo> list = new List<PhoneInfo>();
            while (true)
            {
                PhoneInfo info = new PhoneInfo();
                Console.Write("이름: ");
                info.Name = Console.ReadLine();

                Console.Write("전화번호: ");
                info.Phone = Console.ReadLine();

                Console.Write("생일: ");
                info.Birth = Console.ReadLine();

                list.Add(info);
                //alist.Add(100);
                Console.Write("계속(y), 종료(q)");
                if (Console.ReadLine().ToUpper() == "Q")
                    break;
            }
            foreach (PhoneInfo info in list)
            {
                Console.WriteLine($"{info.Name} {info.Phone} {info.Birth}");
            }
        }    
    }

        public class PhoneInfo : IComparable
        {
            public string Name { get; set; }
            public string Phone { get; set; }
            public string Birth { get; set; }

            #region 생성자
            public PhoneInfo()
            {

            }
            public PhoneInfo(string name)
            {
                Name = name;
            }
            public PhoneInfo(string name, string phone, string birth)
            {
                Name = name;
                Phone = phone;
                Birth = birth;
            }
            #endregion

            public int CompareTo(object obj)
            {
                PhoneInfo info = (PhoneInfo)obj;
                return this.Name.CompareTo(info.Name);
            }
            public override bool Equals(object obj)
            {
                PhoneInfo info = (PhoneInfo)obj;
                return this.Name == info.Name;
            }
            public override int GetHashCode()
            {
                return EqualityComparer<string>.Default.GetHashCode(Name);
            }
        }
}
