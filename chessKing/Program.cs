using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chessKing
{
    class Program
    {
        static void Main(string[] args)
        {
            int y1 = Convert.ToInt32(Console.ReadLine());
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());
            int x2 = Convert.ToInt32(Console.ReadLine());

            if (((Math.Abs(x2 - x1) == 1) || (Math.Abs(x2 - x1) == 0)) && ((Math.Abs(y2 - y1) == 0) || (Math.Abs(y2 - y1) == 1)))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            Console.ReadKey();
        }
    }
}