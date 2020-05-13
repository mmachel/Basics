using System;

namespace myApp
{
	class Program
    {
		//private const string Value = "Wrong operation";
		private const string Value1 = "Click ENTER to continue or type \"end\": ";
		private const string Value2 = "Enter the first number: ";

		static void Main()
        {
			MyCalculator();
			Console.ReadKey();
        }
		private static void MyCalculator()
		{
			double x = 0, y = 0, z;
			char oper = ' ';
			string end;

			do
			{

				try
				{
					Console.Write(Value2);
					x = double.Parse(s: Console.ReadLine());
					Console.Write("Enter the second number: ");
					y = double.Parse(Console.ReadLine());
					Console.Write("Enter the operation[+ - * / % ^ v]: ");
					oper = char.Parse(Console.ReadLine());
				}
				catch (FormatException)
				{

					Console.WriteLine("Wrong format, it shoud be a double number and character for the operation.");
					//return;
				}

				switch (oper)
				{
					case '+':
						z = x + y;
						Console.WriteLine($"{x} + {y} = {z}");
						break;
					case '-':
						z = x - y;
						Console.WriteLine($"{x} - {y} = {z}");
						break;
					case '*':
						z = x * y;
						Console.WriteLine($"{x} * {y} = {z:f5}");
						break;
					case '/':
						z = x / y;
						if (y == 0) { z = Double.NaN; Console.WriteLine($"{x} / {y} = {z:f5}"); }
						else { Console.WriteLine($"{x} / {y} = {z:f5}"); }
						break;
					case '%':
						z = x % y;
						Console.WriteLine($"{x} % {y} = {z}");
						break;
					case '^':
						z = Math.Pow(x, y);
						Console.WriteLine($"{x}^{y} = {z}");
						break;
					case 'v':
						Console.WriteLine($"Sqrt({x}) = {Math.Sqrt(x):f5} and Sqrt({y}) = {Math.Sqrt(y):f5}");
						break;
					//default:
					//	Console.WriteLine(Value);
					//	break;
				}
				Console.Write(Value1);
				end = Console.ReadLine();

			} while (end != "end");
		}
    }
}