using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw2_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool anotherCalc = true;
            int i = 0;
            string[] calculations = new string[10];
            while (anotherCalc == true)
            {
                Console.WriteLine("Enter arithmetic operation ('+', '-', '/', '*'): ");
                string operation = Console.ReadLine();
                while (operation != "+" && operation != "-" && operation != "/" && operation != "*")
                {
                    Console.WriteLine("Wrong input!!! Try again...");
                    operation = Console.ReadLine();
                }
                int num1;
                int num2;
                Console.Write("Enter a first number: ");
                string firstNr = Console.ReadLine();
                bool parsingSuccess = int.TryParse(firstNr, out num1);
                while (parsingSuccess == false)
                {
                    Console.WriteLine("Wrong input...");
                    Console.WriteLine("Enter valid value for First number...");
                    firstNr = Console.ReadLine();
                    parsingSuccess = int.TryParse(firstNr, out num1);
                }

                Console.Write("Enter a second number: ");
                string secondNr = Console.ReadLine();
                parsingSuccess = int.TryParse(secondNr, out num2);
                while (parsingSuccess == false || (operation == "/" && num2 == 0))
                {
                    Console.WriteLine("Wrong input or divide with zero scenario...");
                    Console.WriteLine("Enter valid value for Second number...");
                    secondNr = Console.ReadLine();
                    parsingSuccess = int.TryParse(secondNr, out num2);
                }
                Console.Clear();
                int result=0;
                switch (operation)
                {
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine(num1 + " * " + num2 + " = " + result);
                        break;
                    case "/":
                        result = num1 / num2;
                        Console.WriteLine(num1 + " / " + num2 + " = " + result);
                        break;
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine(num1 + " + " + num2 + " = " + result);
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine(num1 + " - " + num2 + " = " + result);
                        break;
                    default:
                        Console.WriteLine("");
                        break;
                }
                var history = firstNr + " " + operation + " " + secondNr + " = " + result;
                
                calculations[i] = history;
               
                //Console.WriteLine(calculations[i]);
   
                Console.WriteLine("Another calculation? (Y/N)");
                string newCalc = Console.ReadLine();
                while (newCalc !="Y" && newCalc !="N")
                {
                    Console.WriteLine("Wrong input!!! Try again...");
                    newCalc = Console.ReadLine();
                };
                switch (newCalc)
                {
                    case "Y":
                        anotherCalc = true;
                        history = "";
                        i++;
                        Console.Clear();
                        break;
                    case "N":
                        anotherCalc = false;
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("ne e izbrano nitu 'Y' nitu 'N'");
                        break;
                }

            }
            Console.WriteLine("Thanks for using my first Calculator in C#!");
            Console.WriteLine("This is your history calculations...: ");
            foreach (string calc in calculations)
            {
                Console.WriteLine(calc);
            }

            Console.ReadLine();
        }
    }
}
