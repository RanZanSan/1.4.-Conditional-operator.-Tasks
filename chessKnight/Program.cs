using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chessKnight
{
    class Program
    {
        static void Main(string[] args)
        {
            int y1 = Convert.ToInt32(Console.ReadLine());
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());
            int x2 = Convert.ToInt32(Console.ReadLine());

            if (((Math.Abs(x1 - x2) == 1) && (Math.Abs(y1 - y2) == 2)) || ((Math.Abs(x1 - x2) == 2) && (Math.Abs(y1 - y2) == 1)))
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