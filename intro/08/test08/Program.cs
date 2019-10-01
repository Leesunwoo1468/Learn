using System;

namespace test08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("총학생의 수를 입력하세요");
            int totalNumber = int.Parse(Console.ReadLine());
            int index = 0;
            int[] lang = new int[totalNumber];
            int[] eng = new int[totalNumber];
            int[] math = new int[totalNumber];
            int[] total = new int[totalNumber];

            while (index < totalNumber)
            {
                Console.Write(index + 1);
                Console.WriteLine(" 학생의 점수를 입력하세요.");
                Console.WriteLine("");
                Console.WriteLine("국어 점수를 입력하세요.");
                lang[index] = int.Parse(Console.ReadLine());
                Console.WriteLine("영어 점수를 입력하세요.");
                eng[index] = int.Parse(Console.ReadLine());
                Console.WriteLine("수학 점수를 입력하세요.");
                math[index] = int.Parse(Console.ReadLine());

                total[index] = lang[index] + eng[index] + math[index];
                index = index + 1;
            }

            Console.WriteLine("--------------------------------------");
            Console.WriteLine("결과를 표시합니다.");
            index = 0;
            while (index < totalNumber)
            {
                Console.Write(index + 1);
                Console.WriteLine(" 번째 학생");
                Console.Write("총점수: ");
                Console.WriteLine(total[index]);
                Console.Write("평균: ");
                Console.WriteLine(total[index] / 3);

                index = index + 1;
            }
        }
    }
}
