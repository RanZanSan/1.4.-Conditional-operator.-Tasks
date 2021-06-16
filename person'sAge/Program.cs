using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace person_sAge
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());

            if(age < 18 && age < 70)
            {
                Console.WriteLine("ребёнок");
            }
            if(age >= 18 && age < 70)
            {
                Console.WriteLine("взрослый");
            }
            if(age > 18 && age >= 70)
            {
                Console.WriteLine("старик");
            }

            Console.ReadKey();
        }
    }
}