using System;

namespace YangDaHye_ex03_while
{
    class Tree_w
    {
        static void Main(string[] args)
        {
            int a = 0;
            while (a < 5)
            {
                int b = 0;
                while (b <= a)
                {
                    Console.Write("*");
                    b++;
                }
                Console.WriteLine();
                a++;
            }
        }
    }
}
//부등호 방향 틀렷어 바보야;;;;;;; 별짓기