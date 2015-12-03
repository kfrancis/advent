using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    /// <summary>
    /// Day 3: Perfectly Spherical Houses in a Vacuum
    /// </summary>
    public class day3 : ISolvable
    {
        /// <summary>
        /// Santa is delivering presents to an infinite two-dimensional grid of houses.
        /// 
        /// He begins by delivering a present to the house at his starting location, and then an elf at the North Pole calls him via radio and tells him where to move next. 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int SolvePart1(string input)
        {
            var santaPosition = new Position(0, 0);  // Starting position

            var houses = new Dictionary<string, Position>()
            { { "0,0", santaPosition } }; 

            foreach (var item in input.Select((c, i) => new { Value = c, Index = i }))
            {
                switch(item.Value)
                {
                    case '^':
                        santaPosition.Y += 1;
                        break;
                    case 'v':
                        santaPosition.Y -= 1;
                        break;
                    case '>':
                        santaPosition.X += 1;
                        break;
                    case '<':
                        santaPosition.X -= 1;
                        break;
                    default:
                        break;
                }
                if (!houses.ContainsKey(santaPosition.X+","+santaPosition.Y))
                {
                    houses.Add(santaPosition.X + "," + santaPosition.Y, new Position(santaPosition.X, santaPosition.Y));
                }
            }

            return houses.Count;
        }

        /// <summary>
        /// The next year, to speed up the process, Santa creates a robot version of himself, Robo-Santa, to deliver presents with him.
        /// 
        /// Santa and Robo-Santa start at the same location (delivering two presents to the same starting house), then take turns moving based on instructions from the elf, who is eggnoggedly reading from the same script as the previous year.
        /// 
        /// This year, how many houses receive at least one present?
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int SolvePart2(string input)
        {
            var santaPosition = new Position(0, 0);  // Starting position for Santa
            var robotPosition = new Position(0, 0);  // Starting position for RoboSanta

            var houses = new Dictionary<string, Position>()
            { { "0,0", santaPosition } };

            foreach (var item in input.Select((c, i) => new { Value = c, Index = i }))
            {
                switch (item.Value)
                {
                    case '^':
                        if (item.Index % 2 == 0) santaPosition.Y += 1;
                        else { robotPosition.Y += 1; }
                        break;
                    case 'v':
                        if (item.Index % 2 == 0) santaPosition.Y -= 1;
                        else { robotPosition.Y -= 1; }
                        break;
                    case '>':
                        if (item.Index % 2 == 0) santaPosition.X += 1;
                        else { robotPosition.X += 1; }
                        break;
                    case '<':
                        if (item.Index % 2 == 0) santaPosition.X -= 1;
                        else { robotPosition.X -= 1; }
                        break;
                    default:
                        break;
                }

                int currentX = item.Index % 2 == 0 ? santaPosition.X : robotPosition.X;
                int currentY = item.Index % 2 == 0 ? santaPosition.Y : robotPosition.Y;

                if (!houses.ContainsKey(currentX + "," + currentY))
                {
                    houses.Add(currentX + "," + currentY, new Position(currentX, currentY));
                }
            }

            return houses.Count;
        }

        public class Position
        {
            public Position(int x, int y) { X = x; Y = y; }
            public int X { get; set; } = 0;
            public int Y { get; set; } = 0;
        }
    }
}
