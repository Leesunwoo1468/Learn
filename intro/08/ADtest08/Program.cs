using System;

namespace ADtest08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("학생명부 입니다.");
            Console.WriteLine("방법을 선택하세요.");
            Console.WriteLine("1번. 순서대로 입력");
            Console.WriteLine("2번. 직접입력");

            int mainMenu = 0;
            int userInput = int.Parse(Console.ReadLine());

            if (mainMenu + 1 == userInput)
            {

            }
            else if (mainMenu + 2 == userInput)
            {

            }
            while (mainMenu + 1 != userInput && mainMenu + 2 != userInput)
            {
                Console.WriteLine("잘 못 입력하셨습니다.");
                Console.WriteLine("다시 입력하세요.");
                Console.WriteLine("");

            }
        }
    }
}
