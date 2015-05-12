using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nofm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] calc = new int[12, 12];
            for (int i = 0; i <= 11; i++)
            {
                calc[i, 0] = 1;
                calc[i, i] = 1;
            }

            for(int i = 1; i <= 11; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    calc[i, j] = calc[i - 1, j - 1] + calc[i - 1, j];
                    Console.Write(calc[i, j]);
                    Console.Write(" ");
                }

                Console.WriteLine(" ");
            }
        }
    }
}
