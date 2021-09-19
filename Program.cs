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
	    	

    }
}
