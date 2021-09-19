using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
               init();
        }
        public static void init()
		{

			int choice = -1;
			bool exited = false;
			while (true)
			{
				if (exited)
					break;
				printMenu();
				int option = 0;
				string input = Console.ReadLine();
				//If user does not enter integer, it will repeatedly ask user to enter integer.
				while (!(int.TryParse(input, out choice)))
				{
					Console.WriteLine("You must enter an integer");
					input = Console.ReadLine();

				}
				choice = Int32.Parse(input);

				Console.WriteLine(" ");

				switch (choice)
				{
					case 1:
						Console.WriteLine("Enter First Number");
						string firstNumber = Console.ReadLine();
						Console.WriteLine("Enter Second Number");
						string secondNumber = Console.ReadLine();
						addition(Int32.Parse(firstNumber), Int32.Parse(secondNumber));
						break;
					case 2:
                        			Console.WriteLine("Enter base number");
						string baseNumber = Console.ReadLine();
						Console.WriteLine("Enter highest Number");
						string highNumber = Console.ReadLine();
						multiplication(Int32.Parse(baseNumber), Int32.Parse(highNumber));
						break;
					case 3:
						memoryBytes();

					case 9:
						exited = true;
						break;
					default:
						Console.WriteLine("Enter a valid number from 1 to 9");
						break;

				}


			}
		}

		// printMenu() Prints all the menu option. This is being called inside while loop of init() method
		public static void printMenu()
		{
			Console.WriteLine("");
			Console.WriteLine("Enter an option");
			Console.WriteLine("1. Addition");
			Console.WriteLine("2. Multiplication");
			Console.WriteLine("3. Memory Bytes");
		

		}

		public static void addition(int number1, int number2)
		{
			int sum = 0;
			sum = number1 + number2;
			Console.WriteLine("{" + number1 + "}" + " + " + "{" + number2 + "}" + " = " + "{" + sum + "}");
		}
	    	public static void multiplication(int number1, int number2)
        	{
			 int output = 0;

           		 for (int i = 0; i <= number2; i++)
            		{
				output = number1 * i;
				Console.WriteLine(number1 + " * " + i + " = " + output );
			}
			
                 }
	         public static void memoryBytes()
                {
			Console.WriteLine($"sbyte: size: { sizeof(sbyte) }, Min Value: {sbyte.MinValue} , Max Value: {sbyte.MaxValue}");
			Console.WriteLine($"byte:  size: { sizeof(byte) },  Min Value: {byte.MinValue} ,  Max value: {byte.MaxValue}");
			Console.WriteLine($"short: size: { sizeof(short) }, Min value: {short.MinValue} , Max value: {short.MaxValue}");
			Console.WriteLine($"ushort: size: { sizeof(ushort) }, Min Value: {ushort.MinValue} , Max Value: {ushort.MaxValue}");
			Console.WriteLine($"int:    size: { sizeof(int) },   Min Value:  {int.MinValue} , Max Value:{int.MaxValue}");
			Console.WriteLine($"uint:   size:{ sizeof(uint) }, Min Value:  {uint.MinValue} , Max Value:{uint.MaxValue}");
			Console.WriteLine($"long:   size:{ sizeof(long) } , Min Value: {long.MinValue} , Max Value:{long.MaxValue}");
			Console.WriteLine($"ulong:  size:{ sizeof(ulong) } , Min Value: {ulong.MinValue} , Max Value:{ulong.MaxValue}");
			Console.WriteLine($"float:  size:{ sizeof(float) } , Min Value: {float.MinValue} , Max Value:{float.MaxValue}");
			Console.WriteLine($"double: size:{ sizeof(double) } , Min Value: {double.MinValue} ,Max Value: {double.MaxValue}");
			Console.WriteLine($"decimal: size:{ sizeof(decimal) } , Min Value: {decimal.MinValue} ,Max Value: {decimal.MaxValue}");
		}

	    	

    }
}
