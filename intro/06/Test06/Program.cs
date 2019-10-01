using System;

namespace Test06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("정수를 입력하세요.");
            int userInput = int.Parse(Console.ReadLine());

            if (userInput > 20 && userInput % 3 == 0)
            {
                Console.WriteLine("20보다 큰 3의 배수입니다.");
            }
        }
    }
}
