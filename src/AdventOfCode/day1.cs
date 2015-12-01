using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    public class day1 : ISolvable
    {
        /// <summary>
        /// Santa is trying to deliver presents in a large apartment building, but he can't find the right floor - the directions he got are a little confusing. He starts on the ground floor (floor 0) and then follows the instructions one character at a time.
        /// 
        /// An opening parenthesis, (, means he should go up one floor, and a closing parenthesis, ), means he should go down one floor.
        /// 
        /// The apartment building is very tall, and the basement is very deep; he will never find the top or bottom floors.
        /// 
        /// For example:
        /// 
        /// `(())` and `()()` both result in floor 0.
        /// `(((` and `(()(()(` both result in floor 3.
        /// `))(((((` also results in floor 3.
        /// `())` and `))(` both result in floor -1 (the first basement level).
        /// `)))` and `)())())` both result in floor -3.
        /// 
        /// To what floor do the instructions take Santa?
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int SolvePart1(string input)
        {
            return Solve(input);
        }

        /// <summary>
        /// Now, given the same instructions, find the position of the first character that causes him to enter the basement (floor -1). The first character in the instructions has position 1, the second character has position 2, and so on.
        /// 
        /// For example:
        /// 
        /// `)` causes him to enter the basement at character position 1.
        /// `()())` causes him to enter the basement at character position 5.
        /// 
        /// What is the position of the character that causes Santa to first enter the basement?
        /// </summary>
        public int SolvePart2(string input)
        {
            int floor = 0;
            int index = 0;
            foreach (var item in input.Select((c, i) => new { Value = c, Index = i }))
            {
                if (item.Value == '(') { floor++; }
                else if (item.Value == ')') { floor--; }

                if (floor == -1)
                {
                    index = item.Index;
                    break;
                }
            }

            return index+1;
        }

        public int Solve(string input)
        {
            return input.Sum(x => x == '(' ? 1 : x == ')' ? -1 : 0);
        }


    }
}
