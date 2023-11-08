using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace provjeraPravokutnogTrokuta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0, y = 0, z = 0;
            int hipotenuza = 0;
            int kateta1 = 0;
            int kateta2 = 0;
            int rez = 0;


            Console.WriteLine("Ovo je provjera pravokutnog trokuta");
            Console.WriteLine("Unesite vrijednosti veće od nule!");

            do {
                Console.Write("Unesite prvu vrijednost --> ");
                x = Convert.ToInt32(Console.ReadLine());
                } while (x <= 0);
            do
            {
                Console.Write("Unesite drugu vrijednost --> ");
                y = Convert.ToInt32(Console.ReadLine());
            } while (y <= 0);
            do
                {
                Console.Write("Unesite trecu vrijednost --> ");
                z = Convert.ToInt32(Console.ReadLine());
            } while (z <= 0);


            if (x > y && y > z) { 
                hipotenuza = x;
                kateta1 = y;
                kateta2 = z;
            }
            if (y > x && y > z)
            {
                hipotenuza = y;
                kateta1 = x;
                kateta2 = z;
            }
            if (z > y && y > x)
            {
                hipotenuza = z;
                kateta1 = y;
                kateta2 = x;
            }

            rez = kateta1*kateta1 + kateta2*kateta2;
            hipotenuza = hipotenuza * hipotenuza;

            if (hipotenuza == rez)
            {
                Console.Write("Ovo je pravokutni trokut");
            }
            else {
                Console.Write("Ovo nije pravokutni trokut");
            }

            Console.ReadKey();
        }
    }
}
