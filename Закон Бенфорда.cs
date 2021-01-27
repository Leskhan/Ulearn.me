using System;
using System.Text;

namespace STEPIK_C_SHARP
{
    class Program
    {
        public static int[] GetBenfordStatistics(string text)
        {
            string[] words = text.Split(' ', '\n');

            var statistics = new int[10];
            for (int i = 0; i < words.Length; i++)
            {
                string str = words[i];
                if (Char.IsDigit(str[0]))
                {
                    int index = Convert.ToInt32(str[0]) - 48;
                    statistics[index] = ++statistics[index];
                }
            }
            return statistics;
        }

        static void PrintNumbers(int[] array)
        {
            foreach (var e in array)
                Console.Write(e + " ");
        }

        static void Main(string[] args)
        {
            PrintNumbers(GetBenfordStatistics("123 456 789"));
        }
    }
}
