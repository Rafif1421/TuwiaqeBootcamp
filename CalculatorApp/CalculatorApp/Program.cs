
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    // Rafif Alazzaz
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Calculator App ");

           var operation = new Operations();
            int selection;
            double num1,num2, result;
            do
            {
                Console.WriteLine("\n\nSelect which operation you want to do\n" +
                    "Enter 1 for the addition \n" +
                    "Enter 2 for subtraction \n" +
                    "Enter 3 for multiplication \n" +
                    "Enter 4 for dividing \n" +
                    "Enter 0 to Exist");
                selection=Convert.ToInt32(Console.ReadLine());
                if (selection != 0)
                {

                    Console.WriteLine("Enter First number:");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter Second number:");
                    num2 = Convert.ToDouble(Console.ReadLine());

                    switch (selection)
                    {
                        case 1:
                            result = operation.Addition(num1, num2);
                            Console.WriteLine("the result of add operation is " + result);
                            break;
                        case 2:
                            result = operation.Subtraction(num1, num2);
                            Console.WriteLine("the result of substract operation is " + result);
                            break;
                        case 3:
                            result = operation.Multiplication(num1, num2);
                            Console.WriteLine("the result of multiplication operation is " + result);
                            break;
                        case 4:
                            result = operation.Dividing(num1, num2);
                            Console.WriteLine("the result of division operation is " + result);
                            break;
                        default:
                            Console.WriteLine("your select is not available please try again");
                            break;
                    }
                }
            } while (selection!=0);
            Console.WriteLine("thank you, Have a nice day");
            Console.ReadLine();
        }
    }
}
