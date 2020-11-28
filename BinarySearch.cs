using System;
using System.Collections.Generic;
using System.Text;

namespace Prep
{
    public class BinarySearch
    {

        public int Search(int numberToBeSearched, int[] arrayOfNumber,int start, int end)
        {
            while(start <= end)
            {
                int m = (start + end - 1) / 2;

                if(arrayOfNumber[m] == numberToBeSearched)
                {
                    return m;
                }
                else if(numberToBeSearched < arrayOfNumber[m])
                {
                    end = m - 1;
                }
                else
                {
                    start = m + 1;
                }
            }
            return -1;       
        }
    }
}
