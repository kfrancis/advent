using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    /// <summary>
    /// 
    /// </summary>
    public class day4 : ISolvable
    {
        private readonly MD5 _md5;

        public day4()
        {
            _md5 = MD5.Create();
        }

        public int SolvePart1(string input)
        {
            return FindLowestNumber(input, 5);
        }

        public int SolvePart2(string input)
        {
            return FindLowestNumber(input, 6);
        }

        private int FindLowestNumber(string input, int numberOfLeadingZeros)
        {
            int currentNumber = 0;
            string hash = string.Empty;

            while(!hash.StartsWith(new string('0', numberOfLeadingZeros))) 
            {
                currentNumber++;
                hash = CalculateMD5Hash(string.Format("{0}{1}", input, currentNumber));
            }

            return currentNumber;
        }

        private string CalculateMD5Hash(string input)
        {
            // step 1, calculate MD5 hash from input
            
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = _md5.ComputeHash(inputBytes);

            // step 2, convert byte array to hex string
            var sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }
    }
}
