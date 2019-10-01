using System;

namespace DoorLock_6Num
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int passcodelength = 6;

            int[] passcodeNumbers = new int[passcodelength];

            Console.WriteLine("비밀번호: ");
            for (int i = 0; i < passcodelength; i++)
            {
                passcodeNumbers[i] = random.Next(0, 10);
                Console.Write(passcodeNumbers[i]);
                Console.Write(" ");
            }
            Console.WriteLine();

            int[] userInput = new int[passcodelength];

            while (true)
            {
                for (int userInputNumber = 0; userInputNumber <passcodelength; userInputNumber++)
                {
                    Console.Write(userInputNumber);
                    Console.WriteLine(" 번째 숫자를 입력하세요.");
                    userInput[userInputNumber] = int.Parse(Console.ReadLine());
                }

                bool correctPassword = true;
                for (int userInputNumber = 0; userInputNumber < passcodelength; userInputNumber++)
                {
                    if (userInput[userInputNumber] != passcodeNumbers[userInputNumber])
                    {
                        correctPassword = false;
                        Console.WriteLine("비밀번호가 틀렸습니다.");
                        break;
                    }
                }

                if (correctPassword)
                {
                    Console.WriteLine("문이 열렸습니다.");
                    break;
                }
            }
        }
    }
}
