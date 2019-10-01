using System;

namespace test10_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 101);

            while (true)
            {
                Console.WriteLine("숫자를 입력하세요.");
                int userInput = int.Parse(Console.ReadLine());

                if (userInput > randomNumber)
                {
                    Console.WriteLine("더 작은 숫자입니다.");
                }
                else if (userInput < randomNumber)
                {
                    Console.WriteLine("더 큰 숫자입니다.");
                }
                else
                {
                    Console.WriteLine("정답입니다.");
                    break;
                }
            }
        }
    }
}
