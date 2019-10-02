using System;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] cardDeck = {"A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K"};
            String[] cardSuit = { "Spade", "Heart", "Diamond", "Club" };

            Random random = new Random();

            const sbyte number = 10;  //최대로 뽑을 수 있는 카드 수
            string[] dealerCard = new string[number];
            string[] playerCard = new string[number];

            dealerCard[0] = cardDeck[random.Next(0, 12)] + cardSuit[random.Next(0, 3)];
            playerCard[0] = cardDeck[random.Next(0, 12)] + cardSuit[random.Next(0, 3)];

            while (dealerCard[0] == playerCard[0])
            {
                playerCard[0] = cardDeck[random.Next(0, 12)] + cardSuit[random.Next(0, 3)];
            }

            dealerCard[1] = cardDeck[random.Next(0, 12)] + cardSuit[random.Next(0, 3)];
            while (dealerCard[1] == playerCard[0] || dealerCard[1] == dealerCard[0])
            {
                dealerCard[1] = cardDeck[random.Next(0, 12)] + cardSuit[random.Next(0, 3)];
            }

            playerCard[1] = cardDeck[random.Next(0, 12)] + cardSuit[random.Next(0, 3)];
            while (playerCard[1] == dealerCard[0] || playerCard[1] == dealerCard[1] || playerCard[1] == playerCard[0])
            {
                playerCard[1] = cardDeck[random.Next(0, 12)] + cardSuit[random.Next(0, 3)];
            }

            Console.Write("딜러의 카드: ");
            Console.WriteLine(dealerCard[0]);
            Console.WriteLine(" ");
            Console.Write("당신의 카드: ");
            Console.Write(playerCard[0]);
            Console.Write(" ");
            Console.WriteLine(playerCard[1]);
            Console.WriteLine(" ");
            Console.WriteLine("카드를 뽑으시겠나요? 숫자를 입력하세요.");
            Console.WriteLine("1.Draw  2.No");

            sbyte drawCheck = sbyte.Parse(Console.ReadLine());

        }
    }
}
