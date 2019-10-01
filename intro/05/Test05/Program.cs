using System;

namespace Test05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("주머니에는 동전이 10개 들어 있습니다.");
            Console.WriteLine("어머니는 몇 개의 동전을 주머니에 넣었나요.?");
            int Coin = 10;
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("아람이는 몇 개의 동전을 꺼냈나요?");
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("우람이는 몇 개의 동전을 꺼냈나요?");
            int number3 = int.Parse(Console.ReadLine());
            Console.Write("주머니에 남아 있는 동전의 개수는 ");
            Console.Write(Coin + number1 - number2 - number3);
            Console.WriteLine("개입니다.");

        }
    }
}
