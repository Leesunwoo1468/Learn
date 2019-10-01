using System;

namespace Test09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("학급 숫자를 적어주세요.");
            int classNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("학생 숫자를 적어주세요.");
            int classmate = int.Parse(Console.ReadLine());
            int[] total = new int[classNumber];

            for (int i = 0; i < classNumber; i++)
            {
                Console.Write(i + 1);
                Console.WriteLine(" 반의 성정을 적어주세요.");

                int[] classtotal = new int[classmate];

                for (int j = 0; j < classmate; j++)
                {
                    Console.Write(j + 1);
                    Console.WriteLine("번째 학생의 성적을 적어주세요.");
                    classtotal[j] = int.Parse(Console.ReadLine());
                    total[i] = total[i] + classtotal[j];
                }
            }

            Console.WriteLine("각 반의 평균입니다.");

            for (int i = 0; i < classNumber; i++)
            {
                Console.Write(i + 1);
                Console.Write("반의 평균입니다. ");
                Console.Write(total[i] / classmate);
                Console.Write(".");
                Console.WriteLine(total[i] % classmate);
            }
        }
    }
}
