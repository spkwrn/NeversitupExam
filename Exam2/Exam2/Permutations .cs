using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Exam2
{
    public static class Permutations
    {

        public static string[] Shufflings(string input)
        {
            List<string> result = new List<string>();
            List<string> letters = input.Trim().Select(c => c.ToString()).ToList();
            if (letters.Count() == 0)
            {
                return result.ToArray();
            }
         
            List<string> patterns = new List<string>();
            int factorials = getFactorials(letters.Count());
            List<string> lengthPattern = getArrayLength(letters.Count() - 1);

            // find all pattern
            while (patterns.Count() < factorials)
            {
                string[] random = lengthPattern.OrderBy(x => Random.Shared.Next()).ToArray();
                string pattern = string.Join("", random);
                if (!patterns.Contains(pattern))
                {
                    patterns.Add(pattern);
                }

            }

            // pattern index to text
            foreach (string p in patterns)
            {
                List<string> s = p.Select(c => c.ToString()).ToList();
                string text = "";
                for (int i = 0; i < s.Count(); i++)
                {
                    text += letters[int.Parse(s[i])];
                }

                result.Add(text);

            } 

            return result.Distinct().OrderBy(o => o).ToList().ToArray();
        }

        static int getFactorials(int number)
        {
            int factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial = factorial * i;
            }

            return factorial;
        }

        static List<string> getArrayLength(int number)
        {
            List<string> array = new List<string>();
            for (int i = 0; i <= number; i++)
            {
                array.Add(i.ToString());
            }

            return array;
        }

    }
}
