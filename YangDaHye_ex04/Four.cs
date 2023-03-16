using System;

namespace YangDaHye_ex04
{
    class Four
    {
        static void Main(string[] args)
        {
            Console.Write("반복 횟수를 입력하세요. : ");

            string input = Console.ReadLine();
            int number = Convert.ToInt32(input);
            
            if(number > 0)
            {
                for (int a = 0; a < number; a++)
                {
                    for (int b = 0; b <= a; b++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }

            else Console.WriteLine("0보다 작거나 같은 수를 입력할 수 없습니다.");
        }
    }
}
