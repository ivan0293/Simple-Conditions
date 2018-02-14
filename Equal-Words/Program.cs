using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equal_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstW = Console.ReadLine().ToLower();
            var secondW = Console.ReadLine().ToLower();

            if (firstW.Equals(secondW))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }

        }
    }
}
