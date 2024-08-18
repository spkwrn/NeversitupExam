using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2
{
    public static class OddUnit
    {
        public static int FinfOddUnit(int[] numbers)
        {
            IEnumerable<IGrouping<int, int>> query = from number in numbers
                                                     group number by number ;
           
            foreach (var group in query)
            {
                if ((group.Count() % 2) != 0)
                {
                    return group.FirstOrDefault();
                }
            }
            return 0;

        }
    }
}
