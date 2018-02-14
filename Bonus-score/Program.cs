using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_score
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            double bonusScore = 0;

            if (num <= 100)
            {
                bonusScore += 5;
            }
            else if ((num > 100) && (num <= 1000))
            {
                bonusScore += 0.2 * num;
            }
            else
            {
                bonusScore += 0.1 * num;
            }

            if (num % 2 == 0)
            {
                bonusScore += 1;
            }

            if (num % 10 == 5)
            {
                bonusScore += 2;
            }

            double totalScore = bonusScore + num;
            Console.WriteLine(bonusScore);
            Console.WriteLine(totalScore);
        }
    }
}
