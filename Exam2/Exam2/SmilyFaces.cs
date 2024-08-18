using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exam2
{
    public static class SmilyFaces
    {
        public static int CountSmilyFaces(string[] texts)
        {
            int res = 0; 
            foreach (string s in texts)
            {
                string pattern = @"^[:;][-~]?[)D]$";
                // Create a Regex
                Regex rg = new Regex(pattern);
                Match m = rg.Match(s.Trim());
                if (m.Success)
                {
                    res++;
                }
            }
           
            return res;
        }
    }
}
