using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainings
{
    internal class TestArrays
    {
        public static void boolean()
        {
            Random coin = new Random();
            int flip = coin.Next(0, 2);
            Console.WriteLine((flip == 0) ? "heads" : "tails");

            //Random coin = new Random();
            //Console.WriteLine((coin.Next(0, 2) == 0) ? "heads" : "tails");

        }
    }
}
