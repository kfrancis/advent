﻿using System;
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
            string day1Input = File.ReadAllText(@"input\day1.txt");
            Console.WriteLine("DAY1.1: Floor? {0}", day1.SolvePart1(day1Input));
            Console.WriteLine("DAY1.2: Position? {0}", day1.SolvePart2(day1Input));

            var day2 = new day2();
            string day2Input = File.ReadAllText(@"input\day2.txt");
            Console.WriteLine("DAY2.1: Sqft of wrapping paper needed? {0}", day2.SolvePart1(day2Input));
            Console.WriteLine("DAY2.2: Ft of ribbon needed? {0}", day2.SolvePart2(day2Input));

            var day3 = new day3();
            string day3Input = File.ReadAllText(@"input\day3.txt");
            Console.WriteLine("DAY3.1: Houses recieving at least one present? {0}", day3.SolvePart1(day3Input));
            Console.WriteLine("DAY3.2: Houses recieving at least one present with two santas? {0}", day3.SolvePart2(day3Input));

            var day4 = new day4();
            Console.WriteLine("DAY4.1: Lowest number with five leading zeros? {0}", day4.SolvePart1("yzbqklnj"));
            Console.WriteLine("DAY4.2: Lowest number with six leading zeros? {0}", day4.SolvePart2("yzbqklnj"));
        }
    }
}
