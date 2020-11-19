using System;

namespace LR5_2
{
	class Program
	{
		static void Main()
		{
			Console.OutputEncoding = System.Text.Encoding.UTF8;
			Console.Title = "LR5_2";

			code1 code1 = null;
			while (Console.KeyAvailable)
				Console.ReadKey();
			for (; ; )
			{
				int a;
				if (code1 == null)
				{
					double b, c, d;

					Console.WriteLine("Оберіть тип конуса:");
					Console.WriteLine("1. Звичайний");
					Console.WriteLine("2. Зрізаний");
					do
					{
						a = GetNumberKey();
					} while (a < 1 || a > 2);
					switch (a)
					{
						case 1:
							Console.Write("Введіть висоту: ");
							while (!double.TryParse(Console.ReadLine(), out b) || b <= 0)
							{
							}
							Console.Write("Введіть радіус нижньої основи: ");
							while (!double.TryParse(Console.ReadLine(), out c) || c <= 0)
							{
							}
							code1 = new code1(b, c);
							break;
						case 2:
							Console.Write("Введіть висоту: ");
							while (!double.TryParse(Console.ReadLine(), out b) || b <= 0)
							{
							}
							Console.Write("Введіть радіус нижньої основи: ");
							while (!double.TryParse(Console.ReadLine(), out c) || c <= 0)
							{
							}
							Console.Write("Введіть радіус верхньої основи: ");
							while (!double.TryParse(Console.ReadLine(), out d) || d <= 0)
							{
							}
							code1 = new code2(b, c, d);
							break;
					}
				}

				Console.WriteLine("Що Ви хочете зробити?");
				Console.WriteLine("1. Показати інформацію про конус");
				Console.WriteLine("2. Перестворити конус");
				Console.WriteLine("3. Вийти з програми");

				do
				{
					a = GetNumberKey();
				} while (a < 1 || a > 3);
				switch (a)
				{
					case 1:
						code1.ShowInfo();
						break;
					case 2:
						code1 = null;
						break;
					case 3:
						return;
				}
			}
		}
		static int GetNumberKey()
		{
			for (; ; )
			{
				var key = Console.ReadKey(true).Key;
				switch (key)
				{
					case ConsoleKey.D0:
					case ConsoleKey.D1:
					case ConsoleKey.D2:
					case ConsoleKey.D3:
					case ConsoleKey.D4:
					case ConsoleKey.D5:
					case ConsoleKey.D6:
					case ConsoleKey.D7:
					case ConsoleKey.D8:
					case ConsoleKey.D9:
						return key - ConsoleKey.D0;
					case ConsoleKey.NumPad0:
					case ConsoleKey.NumPad1:
					case ConsoleKey.NumPad2:
					case ConsoleKey.NumPad3:
					case ConsoleKey.NumPad4:
					case ConsoleKey.NumPad5:
					case ConsoleKey.NumPad6:
					case ConsoleKey.NumPad7:
					case ConsoleKey.NumPad8:
					case ConsoleKey.NumPad9:
						return key - ConsoleKey.NumPad0;
				}
			}
		}
	}
}
