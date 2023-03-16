using System;

namespace YangDaHye_ex02
{
    class Tw0
    {
        static void Main(string[] args)
        {
            for (int a = 0; a < 5; a++)
            {
                for (int b = 0; a + b < 5; b++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
