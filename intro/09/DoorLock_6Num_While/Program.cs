using System;

namespace DoorLock_6Num
    {
        class Program
        {
            static void Main(string[] args)
            {
                int[] passcodeNumbers = { 6, 2, 1, 9, 4, 7 };
                int passcodelength = 5;
                int[] userInput = new int[passcodelength];

                while (true)
                {
                    for (int index = 0; index < passcodelength; index++)
                    {
                        Console.Write(index + 1);
                        Console.WriteLine(" 번째 숫자를 입력하세요.");
                        userInput[index] = int.Parse(Console.ReadLine());
                    }
                    bool ispasswordCorrect = true;
                    for (int Index = 0; Index < passcodelength; Index++)
                    {
                        if (userInput[Index] != passcodeNumbers[Index])
                        {
                        ispasswordCorrect = false;
                        Console.WriteLine("비밀번호가 틀렸습니다.");
                        break;
                        }
                    }

                    if (ispasswordCorrect)
                    {
                        Console.WriteLine("문이 열렸습니다.");
                        break;
                    }
                }
            }
        }
    }
