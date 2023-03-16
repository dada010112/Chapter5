using System;

namespace YangDaHye_ex01
{
    class One
    {
        static void Main(string[] args)
        {
            for (int a = 0; a < 5; a++)
            {
                for (int b = 0; b <= a; b++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}