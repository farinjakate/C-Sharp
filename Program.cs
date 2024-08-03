using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _10_ArrayDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a = 10;//declaration & initialization
            //int b;// declaration
            //b = 10;// initializaton




            //declaring array first way
            // int[] fees = new int[3];
            //  Console.WriteLine($" number of Items ={fees.Length}");
            #region Array
            //int[] fees = new int[3];
            //fees[0] = 1000;
            //fees[1] = 12000;
            //fees[2] = 3000;
            //Console.WriteLine($"number of Items = {fees.Length}");
            //for (int Q = 0; Q < fees.Length; Q++)
            //{
            //    Console.WriteLine($"{fees[Q]}");
            //}

            #endregion  Array

            #region String Array
            //string[] paidfees = new string[3];
            //paidfees[0] = "fifteen thousand";
            //paidfees[1] = "ten thousand";
            //paidfees[2] = "five thousand";

            //Console.WriteLine($"number of Items = {paidfees.Length}");
            //for(int g=0; g<paidfees.Length; g++)
            //{
            //    Console.WriteLine($"{paidfees[g]}");

            //}
            #endregion String Array


            #region second way to declare a array
            //string[] names = new string[] { "fiza", "sabiha", "farin" };
            //Array Initializer syntax
            //Console.WriteLine($"number of names : {names.Length}");

            //for (int g = 0; g < names.Length; g++)
            //{
            //    Console.Write($"\n{names[g]} ");
            //}
            #endregion second way to declare a array

            #region we can any time  initialize the array
            //string[] email = null;////here just declared array
            //                      ////Console.WriteLine($"number of email Items ={email.Length}");
            //                      //runtime error


            //email = new string[] {"a@aemail", "p@pemail"};

            //Console.WriteLine($"number of  email Items ={email.Length}");
            #endregion we can any time  initialize the array




            #region Reveres Array
            //int[] numbers = new int[] { 4, 8, 6, 9, 2 };
            //Console.WriteLine("Original Items");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write($"{numbers[i]} ");
            //}
            //Console.WriteLine(); // To move to the next line after printing the original items

            //Console.WriteLine("Reveres Array");
            //for (int i = numbers.Length - 1; i >= 0; i--)
            //{
            //    Console.Write($"{numbers[i]}  ");
            //}
            #endregion Reveres Array

            #region find highest number

            //int[] numbers = new int[] { 4, 8, 6, 9, 2 };
            //int highest = numbers[0];
            //for (int i = 1; i < numbers.Length; i++)
            //{
            //    if (highest < numbers[i])
            //        highest = numbers[i];
            //}
            //{
            //    Console.WriteLine($"highest number:{highest}");
            //}


            //int[] number = new int[] { 23, 34, 25, 33, 55, 22, 11, 60, 45, 24 };
            //int highest =number[0];
            //for (int i = 1; i < number.Length; i++) 
            //{
            //    if (highest < number[i])
            //        highest = number[i];
            //}
            //Console.WriteLine($"highest number:{highest}");

            #endregion find highest number
            //int[] number = new int[] { 90, 34, 67, 88, 55, 23, 45, 67, 45};
            //int highest =number [0];
            //for(int q=1; q<number.Length; q++)
            //{
            //    if (highest < number[q]) 
            //    highest = number[q];
            //}
            //Console.WriteLine($"highest number :{highest}");


            #region reverse input string
            //Console.WriteLine("please enter your name");
            //string name = Console.ReadLine();

            //string reverseName = string.Empty;

            //for (int i = name.Length - 1; i >= 0; i--)
            //{
            //    reverseName += name[i];
            //}
            //Console.WriteLine($"Input:{name}  Output:{reverseName}");



            //Console.WriteLine("Please enter a sentence");
            //string sentence = Console.ReadLine();

            //string[] words = sentence.Split(new char[] { ' ' });
            //Console.WriteLine("output :  \n");
            //for (int e = words.Length - 1; e >= 0; e--)
            //{
            //    Console.Write($"{words[e]} ");
            //}
            #endregion reverse input string

            //int[] numbers = new int[] { 1, 2, 3, 4, 5, 6 };
            //Console.WriteLine("Original items");

            //for(int i=0; i<numbers.Length;i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //Console.WriteLine("ReveseArray number");
            //for(int i=numbers.Length-1; i>=0; i--)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //int[] numbers = new int[] { 4, 8, 6, 9, 2 };
            //Console.WriteLine("Original Items");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write($"{numbers[i]} ");
            //}

            //Console.WriteLine(); /

            //Console.WriteLine("Reversed Array");
            //for (int i = numbers.Length - 1; i >= 0; i--)
            //{
            //    Console.Write($"{numbers[i]}  ");
            //}


            Console.ReadLine();
        }
    }
}
