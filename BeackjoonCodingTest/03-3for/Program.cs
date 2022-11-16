using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_3for
{
    internal class Program
    {
        //X보다 작은 수

        //정수 N개로 이루어진 수열 A와 정수 X가 주어진다. 이때, A에서 X보다 작은 수를 모두 출력하는 프로그램을 작성하시오.
        //예제 입력 10 5
        //1 10 4 9 2 3 8 5 7 6
        //출력 1 4 2 3
        static void Main(string[] args)
        {
            // s[0] 수열의 A, s[1]은 정수 x
            string[] s = Console.ReadLine().Split();

            //s[0]을 이루는 수열들
            string[] q = Console.ReadLine().Split();

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < int.Parse(s[0]); i++)
            {//정수 x보다 작은 숫자들을 검출
                if (int.Parse(s[1]) > int.Parse(q[i]))
                {
                    //해당 숫자들을 sb에 공백과 함께 추가한다.
                    sb.Append(q[i] + " ");
                }
                
                
            }
            Console.Write(sb.ToString());
            Console.ReadKey();
        }
    }
}
