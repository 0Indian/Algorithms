using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class InsertionSort
    {
        // Time Complexity O(n^2)
        // Takes mazimum time when reverse sorted
        // and Best time when the list is already sorted
        public void Sort(int[] arr)
        {
            for(int  i = 0; i  < arr.Length; i++)
            {
                int key = arr[i];
                int j = i - 1;

                while( j>=0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }
        }
    }
}
