using System;

namespace MyMain
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");

			Console.Write("\nWhat's your name? ");

			Console.ReadLine();

			var name = Console.ReadLine();

			Console.WriteLine($"\n\nHello {name}!");

			Console.Read();
		}
	}
}