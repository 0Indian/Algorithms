using System;

namespace Prep
{
    public static class ArrayProblems
    {
        // Calculates the Maximum value of i*Arr(i) and returns it.
        public static int CalcultingMaxiarri()
        {
            int max = 0;







            return max;

        }
        //Rotation of array elements to left and stored in a different array
        public static int[] RotateLeft(int[] array,int d, int n)
        {
            int[] rotatedArray = new int[n];
            for(int elementIndex = 0; elementIndex < n; elementIndex++)
            {
                rotatedArray[elementIndex] = array[(elementIndex - (d+1) + n)%n];
            }
            return rotatedArray;
        }
        // Rotating 1 left element to left in the same array
        public static int[] CyclicRotation(int[] array, int n)
        {
            int temp = array[n - 1];
            for(int element = n-2; element >= 0; element--)
            {
                array[element+1] = array[element];
            }
            array[0] = temp;
            return array;
        }
    }
}
