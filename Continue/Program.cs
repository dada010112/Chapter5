using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Continue
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <10; i ++)
            {
                if (i % 2 == 0)
                    continue;

                Console.WriteLine($"{i}:홀수");
            }
        }
    }
}
//짝수는 if문 조건과 cintinue에 의해 출력되지 않고 1,2,5,7,9만 줄줄이 1:홀수 식으로 출력
