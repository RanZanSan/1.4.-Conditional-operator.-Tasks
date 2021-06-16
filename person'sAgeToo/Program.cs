using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace person_sAgeToo
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());

            if (age < 18)
            {
                Console.WriteLine("ребёнок");
            }
            else if (age < 70)
            {
                Console.WriteLine("взрослый");
            }
            else
            {
                Console.WriteLine("старик");
            }

            Console.ReadKey();
        }
    }
}