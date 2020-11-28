using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class MergeSort
    {
        public void Sort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;
                Sort(arr, left, middle);
                Sort(arr, middle + 1, right);
                MergeArrays(arr, left, middle, right);
            }
        }

        private void MergeArrays(int[] arr, int left, int middle, int right)
        {
            int n1 = middle - left + 1;
            int n2 = right - middle;

            int[] L = new int[n1];
            int[] R = new int[n2];

            int i = 0, j = 0, k = left;
            for (i = 0; i < n1; i++)
            {
                L[i] = arr[left + i];
            }
            for (j = 0; j < n2; j++)
            {
                R[j] = arr[middle + 1 + j];
            }

            i = 0;
            j = 0;

            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }

            /* Copy remaining elements of L[] if any */
            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }

            /* Copy remaining elements of R[] if any */
            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
        }


        public static void printArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
            {
                Console.WriteLine(arr[i] + " ");
            }
        }
    }
    
    }

