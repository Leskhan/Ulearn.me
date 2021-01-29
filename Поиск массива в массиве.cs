using System;
using System.Text;

namespace STEPIK_C_SHARP
{
    class Program
    {
        public static bool EqualsArray(int[] temp, int[] array)
        {
            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i] != array[i])
                    return false;
            }

            return true;
        }

        public static bool ContainsAtIndex(int[] array, int[] subArray, int i)
        {
            if (subArray.Length == 0)
                return true;

            int sizeSubarray = subArray.Length;
            int[] tempArray = new int[sizeSubarray];

            for (int j = 0; j < array.Length - sizeSubarray + 1; j++)
            {
                int step = 0;
                for (int index = j; index < sizeSubarray + j; index++)
                {
                    tempArray[step] = array[index];
                    step++;
                }

                if (EqualsArray(tempArray, subArray) && j == i)
                    return true;
            }

            return false;
        }

        public static int FindSubarrayStartIndex(int[] array, int[] subArray)
        {
            for (var i = 0; i < array.Length - subArray.Length + 1; i++)
                if (ContainsAtIndex(array, subArray, i))
                    return i;
            return -1;
        }

        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 3, 4, 5 };
            int[] subArray = { 4, 3, 4 };

            Console.WriteLine(FindSubarrayStartIndex(array, subArray));
        }
    }
}
