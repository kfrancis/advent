using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    /// <summary>
    /// Day 2: I Was Told There Would Be No Math
    /// </summary>
    public class day2 : ISolvable
    {
        /// <summary>
        /// The elves are running low on wrapping paper, and so they need to submit an order for more. 
        /// They have a list of the dimensions (length l, width w, and height h) of each present, and 
        /// only want to order exactly as much as they need.
        ///
        /// Fortunately, every present is a box (a perfect right rectangular prism), which makes 
        /// calculating the required wrapping paper for each gift a little easier: find the surface 
        /// area of the box, which is 2*l*w + 2*w*h + 2*h*l. The elves also need a little extra paper 
        /// for each present: the area of the smallest side.
        ///
        /// For example:
        ///
        /// 1. A present with dimensions 2x3x4 requires 2*6 + 2*12 + 2*8 = 52 square feet of wrapping 
        /// paper plus 6 square feet of slack, for a total of 58 square feet.
        /// 
        /// 2. A present with dimensions 1x1x10 requires 2*1 + 2*10 + 2*10 = 42 square feet of wrapping 
        /// paper plus 1 square foot of slack, for a total of 43 square feet.
        /// 
        /// All numbers in the elves' list are in feet. How many total square feet of wrapping paper 
        /// should they order?
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int SolvePart1(string input)
        {
            int sumTotal = 0;

            foreach (var line in input.Split('\n').ToList())
            {
                int l = 0, w = 0, h = 0;

                l = Convert.ToInt32(line.Split('x')[0]);
                w = Convert.ToInt32(line.Split('x')[1]);
                h = Convert.ToInt32(line.Split('x')[2]);

                int minArea = l * w;
                if (w * h < minArea) minArea = w * h;
                if (h * l < minArea) minArea = h * l;

                sumTotal += (2 * l * w + 2 * w * h + 2 * h * l) + (minArea);
            }

            return sumTotal;
        }

        /// <summary>
        /// The elves are also running low on ribbon. Ribbon is all the same width, so they only 
        /// have to worry about the length they need to order, which they would again like to be 
        /// exact.
        /// 
        /// The ribbon required to wrap a present is the shortest distance around its sides, or 
        /// the smallest perimeter of any one face. Each present also requires a bow made out of 
        /// ribbon as well; the feet of ribbon required for the perfect bow is equal to the cubic 
        /// feet of volume of the present. Don't ask how they tie the bow, though; they'll never 
        /// tell.
        /// 
        /// For example:
        /// 
        /// 1. A present with dimensions 2x3x4 requires 2+2+3+3 = 10 feet of ribbon to wrap the 
        /// present plus 2*3*4 = 24 feet of ribbon for the bow, for a total of 34 feet.
        /// 
        /// 2. A present with dimensions 1x1x10 requires 1+1+1+1 = 4 feet of ribbon to wrap the 
        /// present plus 1*1*10 = 10 feet of ribbon for the bow, for a total of 14 feet.
        /// 
        /// How many total feet of ribbon should they order?
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int SolvePart2(string input)
        {
            int sumTotal = 0;

            foreach (var line in input.Split('\n').ToList())
            {
                var dimensions = new List<int>();

                dimensions.Add(Convert.ToInt32(line.Split('x')[0]));
                dimensions.Add(Convert.ToInt32(line.Split('x')[1]));
                dimensions.Add(Convert.ToInt32(line.Split('x')[2]));

                dimensions.Sort();

                sumTotal += (dimensions[0]*2+dimensions[1]*2) + (dimensions[0]*dimensions[1]*dimensions[2]);
            }

            return sumTotal;
        }
    }
}
