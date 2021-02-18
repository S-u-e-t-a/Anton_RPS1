using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstLab
{
    class Counting
    {
        public int CountNegative(int[] array)
        {
            int max = array[0];
            int indexOfMax = 0;
            int countofNegative = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max && array[i] > 0)
                {
                    max = array[i];
                    indexOfMax = i;
                }
            }

            for (int i = 0; i < indexOfMax; i++)
            {
                if (array[i] < 0)
                {
                    countofNegative++;
                }
            }
            if (max == array[0] && (indexOfMax != 0 || max < 0))
                return -1;
            return countofNegative;
        }
    }
}
