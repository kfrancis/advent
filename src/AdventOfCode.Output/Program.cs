using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Output
{
    class Program
    {
        static void Main(string[] args)
        {
            var day1 = new day1();
            var day1Input = File.ReadAllText(@"input\day1.txt");
            Console.WriteLine("DAY1.1: Floor {0}", day1.SolvePart1(day1Input));
            Console.WriteLine("DAY1.2: Position {0}", day1.SolvePart2(day1Input));

            var day2 = new day2();
            var day2Input = File.ReadAllText(@"input\day2.txt");
            Console.WriteLine("DAY2.1: Sqft of wrapping paper needed {0}", day2.SolvePart1(day2Input));
            Console.WriteLine("DAY2.1: Ft of ribbon needed {0}", day2.SolvePart2(day2Input));
        }
    }
}
