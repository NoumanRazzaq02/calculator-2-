using System;
using System.Diagnostics;

namespace Advcalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, number3, number4, number5, myChoice, number6, number8;
           
            bool isCondition = false;
            char operation;

            Console.WriteLine("Calculator assignment 2 " + "\n");
            Console.Write("Enter Number:");
            number1 = int.Parse(Console.ReadLine());

            do
            {

                Console.Write("Enter Operator( +,-,*,/,%,s(square) ):");
                operation = char.Parse(Console.ReadLine());


                if (operation == '+')
                {
                    Console.Write("Enter Number:");
                    number2 = int.Parse(Console.ReadLine());
                    number1 = number1 + number2;


                }
                else if (operation == '-')
                {
                    Console.Write("Enter Number:");
                    number3 = int.Parse(Console.ReadLine());
                    number1 = number1 - number3;

                }
                else if (operation == '*')
                {
                    Console.Write("Enter Number:");
                    number4 = int.Parse(Console.ReadLine());
                    number1 = number1 * number4;

                }
                else if (operation == '/')
                {
                    Console.Write("Enter Number:");
                    number5 = int.Parse(Console.ReadLine());
                    number1 = number1 / number5;


                }
                else if (operation == '%')
                {
                    Console.Write("Enter Number:");
                    number6 = int.Parse(Console.ReadLine());
                    number1 = number1 % number6;


                }
               
                else if (operation == 's')
                {
                    Console.Write("Enter Number:");
                    number8 = int.Parse(Console.ReadLine());
                    number1 += number8 * number8;


                }
                Console.Write("Do you want to proceed (Yes:1/No:2) :");
                myChoice = int.Parse(Console.ReadLine());
                if (myChoice == 1)
                {
                    isCondition = true;
                }
                else
                    if (myChoice == 2)
                {
                    isCondition = false;
                    Console.WriteLine("Result is: " + number1);
                   
                }

            } while (isCondition);

        }
    }

}
