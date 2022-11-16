using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Array
{
    //N개의 정수가 주어진다. 이때, 최솟값과 최댓값을 구하는 프로그램을 작성하시오.
    //첫째 줄에 정수의 개수 N . 둘째 줄에는 N개의 정수를 공백으로 구분해서 주어진다..
    //입력 5
    //20 10 35 30 7
    //출력 7 35
    internal class Program
    {
        static void Main(string[] args)
        {
            //입력받음
            int n = int.Parse(Console.ReadLine());

            //입력받은 숫자 길이만큼의 배열을 생성
            int[] arr = new int[n];

            //두번째로 입력받는 숫자들을 공백 기준으로 잘라서 배열로 저장
            string[] s = Console.ReadLine().Split();

            //int로 바꿔서 저장
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(s[i]);
            }
            //배열을 정렬
            Array.Sort(arr);

            //배열의 맨 앞과 맨 뒤 출력
            Console.WriteLine($"{arr[0]} {arr[n - 1]}");
            Console.ReadKey();
        }
    }
}
