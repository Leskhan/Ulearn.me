using System;

namespace STEPIK_C_SHARP
{
    class MainProgram
    {
		public static string RemoveStartSpaces(string text)
		{
			return text.Trim();
		}

		public static void Main()
		{
			Console.WriteLine(RemoveStartSpaces("a"));
			Console.WriteLine(RemoveStartSpaces(" b"));
			Console.WriteLine(RemoveStartSpaces(" cd"));
			Console.WriteLine(RemoveStartSpaces(" efg"));
			Console.WriteLine(RemoveStartSpaces(" text"));
			Console.WriteLine(RemoveStartSpaces(" two words"));
			Console.WriteLine(RemoveStartSpaces("  two spaces"));
			Console.WriteLine(RemoveStartSpaces("	tabs"));
			Console.WriteLine(RemoveStartSpaces("		two	tabs"));
			Console.WriteLine(RemoveStartSpaces("                             many spaces"));
			Console.WriteLine(RemoveStartSpaces("               "));
			Console.WriteLine(RemoveStartSpaces("\n\r line breaks are spaces too"));
		}
	}
}
