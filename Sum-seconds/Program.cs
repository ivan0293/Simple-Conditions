using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            var sec1 = int.Parse(Console.ReadLine());
            var sec2 = int.Parse(Console.ReadLine());
            var sec3 = int.Parse(Console.ReadLine());

            var sum = sec1 + sec2 + sec3;

            var mins = 0;

            if (sum < 59)
            { sum = sec1 + sec2 + sec3; }

            if (sum >= 60 && sum <= 119)
            { mins++; sum = sec1 + sec2 + sec3 - 60; }

            if (sum >= 120 && sum <= 179)
            { mins++; mins++; sum = sec1 + sec2 + sec3 - 120; }

            if (sum < 10)
                Console.WriteLine(mins + ":" + "0" + sum);
            else
                Console.WriteLine(mins + ":" + sum);
        }
    }
}
