using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeackjoonCodingTest
{
    internal class Program
    {
        static void Main(string[] args)
        {//백준 시작 스트링빌더
            StringBuilder sb = new StringBuilder();

            int t = int.Parse(Console.ReadLine());

            int[] a = new int[t];
            int[] b = new int[t];

            for (int i = 0; i < t; i++)
            {
                string[] s = Console.ReadLine().Split();

                a[i] = int.Parse(s[0]);
                b[i] = int.Parse(s[1]);

                sb.Append(a[i] + b[i] + "\n");
            }
            //합들이 저장 되었다가 한 번에 출력된다.
            Console.WriteLine(sb.ToString());
            Console.ReadKey();





        }
    }
}
