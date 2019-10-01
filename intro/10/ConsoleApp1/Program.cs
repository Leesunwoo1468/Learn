using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool result = true;
            while (result)
            {
                Random random = new Random();

                int cpuNumber = random.Next(1, 4);
                int userInput = int.Parse(Console.ReadLine());

                if (cpuNumber == userInput)
                {
                    Console.WriteLine("비겼습니다.");
                    continue;
                }
                else if ((userInput == 1 && cpuNumber == 3) || (userInput == 2 && cpuNumber == 1) || (userInput == 3 && cpuNumber == 2))
                {
                    Console.WriteLine("이겼습니다.");
                    break;
                }
                else
                {
                    Console.WriteLine("졌습니다.");
                    break;
                }
            }
        }
    }
}
