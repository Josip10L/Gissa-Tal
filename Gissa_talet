using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gissa_talet
{
    class Program
    {
        static void Main(string[] args)
        {
            Random slump = new Random();
            int talet = slump.Next(1, 101);
            int försök = 0;
            int x = 1;
            Console.WriteLine("Jag tänker på ett tal mellan 1 och 100. Gissa vilket");
            while (x == 1)
            {
                int svar = int.Parse(Console.ReadLine());
                försök++;
                if (svar == talet)
                {
                    Console.WriteLine("Rätt!");
                    x++;
                }
                else if (svar < talet)
                {
                    Console.WriteLine("Talet som jag tänker på är större än så. Gissa igen");
                }
                else
                {
                    Console.WriteLine("Talet som jag tänker på är mindre än så. Gissa igen");
                }
            }
            Console.WriteLine("Det tog dig " + försök + " försök att gissa talet.");
        }
    }
}
