using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {

        Console.WriteLine("Moe's calculator");

        // dowhile or while loop to display user ins
        while (true)
        {
            Console.WriteLine(" Give me a number, operation another number");

            string input = Console.ReadLine();

            //check if input = exit stop program
            if (input.ToLower() == "exit")
            {
                break;
            }

            // token split (split user input into array of strings
            string[] strings = input.Split(' ');

            if (strings.Length != 3)
            {
                Console.WriteLine("Invalid expression format");
            }

            //
            double num1 = double.Parse(strings[0]);
            string operation = strings[1];
            double num2 = double.Parse(strings[2]);

            double result = 0;

            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;

                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 == 0) 
                    {
                        Console.WriteLine("cant be divide by zero");
                    }
                    result = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Invalid operator");
                    break;
            }
            Console.WriteLine($" Result : {result}");
        }

        Console.WriteLine("you exit");




    }
}

// check if token length == less than 3 or more then throw exp or alrt

// define the three viaribles and result set to 0

// switch with operation variable as argu, check each operation as case and set result
// throw ex at defualt level 

// consolwr result 
// disapy that customer exit