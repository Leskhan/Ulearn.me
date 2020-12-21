using System;

namespace STEPIK_C_SHARP
{
    class MainProgram
    {
        private static void WriteBoard(int size)
        {
            string sharp = "#";
            string dot = ".";

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; )
                {
                    if (j < size)
                    {
                        Console.Write(sharp);
                        j++;
                    }
                    else
                        break;

                    if (j < size)
                    {
                        Console.Write(dot);
                        j++;
                    }
                    else
                        break;

                }
                Console.WriteLine();
                string temp = sharp;
                sharp = dot;
                dot = temp;

            }
        }

        public static void Main()
		{
            WriteBoard(8);
            WriteBoard(1);
            WriteBoard(2);
            WriteBoard(3);
            WriteBoard(10);
        }
	}
}
