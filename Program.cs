using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_ConditionalStatementsExamples
{
    internal class Program
    {
        static void Main(string[] args)
          {
            //    Console.WriteLine("Please enter first number");
            //    int first = int.Parse(Console.ReadLine());

            //    Console.WriteLine("Please enter second number");
            //    int second = int.Parse(Console.ReadLine());

            //    Console.WriteLine("Please enter third number");
            //    int third = int.Parse(Console.ReadLine());

            //    Console.WriteLine($"You enterd :{first},{second},{third}");





            #region nested is else

            //if (first > second)
            //{
            //    if (first > third)
            //    {
            //        Console.WriteLine($"{first} is greater number");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{third} is greater number");
            //    }
            //}   
            //else if (second > first)
            //{
            //    if (second > third)
            //    {
            //        Console.WriteLine($"{second} is greater number");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{third} is greater number");
            //    }
            //}
            //else
            //{
            //    if (first > third)
            //    {
            //        Console.WriteLine($"{first}, {second} are greater number");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{third} is greater number");
            //    }
            //}




            #endregion nested is else


            #region nested Ternary operator
            //ternary perator
            // //int number = (first > second) ? first : second;


            //int number = (first > second) ?
            //  ((first > third) ? first : third) :
            //((second > third) ? second : third);

            //Console.WriteLine($"{number} is greater number");



            #endregion nested Ternary operator


            #region divisible 3 & 5

            //if input number is divisible by 3=THREE
            //iF input number is divisible by 5=FIVE
            //if input number is divisible by 3 & 5 =THREEFIVE

            //Console.WriteLine("Please Enter a number");
            //int num = int.Parse(Console.ReadLine());



            //if (num % 3 == 0 && num % 5 == 0)
            //{
            //    Console.WriteLine("THREE AND FIVE");
            //}
            //else if (num % 3 == 0)
            //{
            //    Console.WriteLine("THREE");
            //}
            //else if (num % 5 == 0)
            //{
            //    Console.WriteLine("FIVE");
            //}

            #endregion divisible 3 & 5



            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= 5; j++)
            //    { Console.Write($"{j}\t")
            //            }
            //    Console.WriteLine();
            //}

            #region even/odd number

            // Ternary operator

            //Console.WriteLine("Please enter a number");
            //int num = int.Parse(Console.ReadLine());

            //string result = (num % 2 == 0) ? "Even" : "Odd";

            //Console.WriteLine($"{num} is {result} number");

            #endregion even / odd



            #region grade meaning

            //Console.WriteLine("please enter a number");
            //char grade = char.Parse(Console.ReadLine());

            //switch (grade)
            //{
            //    case 'A':

            //            Console.WriteLine($"{grade}:Distinction");
            //            break;

            //    case 'B':

            //            Console.WriteLine($"{grade}: First class");
            //            break;

            //    case 'C':

            //            Console.WriteLine($"{grade}:second class");
            //            break;

            //    case 'F':

            //            Console.WriteLine($"{grade}: Failed"); 
            //            break;

            //    default:

            //        Console.WriteLine($"{grade} : Invalid Grade");
            //        break;

            //}














            #endregion grade meaning

            Console.ReadLine();













        }
    }
}
