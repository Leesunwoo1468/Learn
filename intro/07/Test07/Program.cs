using System;

namespace Test07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("시험 점수 계산 프로그램.");

            int[] Test = new int[5];

            Console.WriteLine("국어 점수를 입력하세요.");
            Test[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("영어 점수를 입력하세요.");
            Test[1] = int.Parse(Console.ReadLine());
            Console.WriteLine("수학 점수를 입력하세요.");
            Test[2] = int.Parse(Console.ReadLine());
            Console.WriteLine("과학 점수를 입력하세요.");
            Test[3] = int.Parse(Console.ReadLine());
            Console.WriteLine("사회 점수를 입력하세요.");
            Test[4] = int.Parse(Console.ReadLine());

            if (Test[0] + Test[1] + Test[2] + Test[3] + Test[4] <= 501)
            {
                Console.Write("총 점수: ");
                Console.WriteLine(Test[0] + Test[1] + Test[2] + Test[3] + Test[4]);
                Console.Write("평균 점수: ");
                Console.WriteLine((Test[0] + Test[1] + Test[2] + Test[3] + Test[4]) / 5);
            }
            else
            {
                Console.WriteLine("점수가 잘 못 입력 되었습니다.");
            }
        }
    }
}
