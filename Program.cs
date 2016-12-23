using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace softuniCamp
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = 0;
            var microbus = 0;
            var smallAutobus = 0;
            var bigAutobus = 0;
            var train = 0;

            var total = 0;

            var nGroup = int.Parse(Console.ReadLine());

            for (int i = 0; i < nGroup; i++)
            {
                var nPeople = int.Parse(Console.ReadLine());
                total += nPeople;

                if (nPeople<=5)
                {
                    car += nPeople;
                }
                else if (nPeople>=6&&nPeople<=12)
                {
                    microbus += nPeople;
                }
                else if (nPeople >= 13 && nPeople <= 25)
                {
                    smallAutobus += nPeople;
                }
                else if (nPeople >= 27 && nPeople <= 40)
                {
                    bigAutobus += nPeople;
                }
                else if (nPeople >=45)
                {
                    train += nPeople;
                }

            }
            decimal carN= (car * 100.0m) / total;

            Console.WriteLine("{0:f2}%", (car * 100.0m) / total);
            Console.WriteLine("{0:f2}%", (microbus * 100.0m) / total);
            Console.WriteLine("{0:f2}%", (smallAutobus * 100.0m) / total);
            Console.WriteLine("{0:F2}%", (bigAutobus * 100.0m) / total);
            Console.WriteLine("{0:f2}%", (train * 100.0m) / total);



        }
        Console.WriteLine(  "ihuuuu");
    }
}
