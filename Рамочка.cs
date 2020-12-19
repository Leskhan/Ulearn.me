 using System;

namespace STEPIK_C_SHARP
{
    class MainProgram
    {
        static void WriteTopAndBottomBorder(int size)
        {
            Console.Write("+-");
            for (int i = 0; i < size; i++)
                Console.Write("-");
            Console.WriteLine("-+");
        }

        private static void WriteTextWithBorder(string text)
        {
            int size = text.Length;
            WriteTopAndBottomBorder(size);           

            Console.WriteLine("| " + text + " |");

            WriteTopAndBottomBorder(size);
        }

        static void Main(string[] args)
        {
            WriteTextWithBorder("Menu:");
            //WriteTextWithBorder("");
            //WriteTextWithBorder(" ");
            //WriteTextWithBorder("Game Over!");
            //WriteTextWithBorder("Select level:");
        }
    }
}
