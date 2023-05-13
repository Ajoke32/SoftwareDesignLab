using System;

namespace lab5.Command
{
	internal static class HightLighter
	{
		public static void HightLight(string text)
		{
			Console.ForegroundColor = ConsoleColor.Green;
			System.Console.WriteLine(text);
			Console.ForegroundColor = ConsoleColor.White;
		}

		public static void UndoHightLight(string text)
		{
			Console.ForegroundColor = ConsoleColor.White;
			System.Console.WriteLine(text);
			Console.ForegroundColor = ConsoleColor.White;
		}
	}
}
