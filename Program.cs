using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_ConditionalStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int i= 12;
            //if (i == 10)// condition operator output is always true or false
            // {

            //  console.writeline($"{i} : ten");
            //  console.writeline("even");
            // }    
            // else
            // {
            //     console.writeline($"{i} : not ten");
            // }


            // OR
            //Ternary operator
            //(condition) ? Statement1(true) : Statement2(false);

            //i = 30;
            //string result = (i == 10) ? "ten" : "not ten";
            //console.writeline($"{i} :{result}");

            //OR
            //if-else if-else ladder
            //i = 40;
            //if (i == 10)
            //{
            //    Console.WriteLine($"{i}:TEN");
            //}
            //else if (i == 20)
            //{
            //    Console.WriteLine($"{i}:TWENTY");
            //}
            //else if (i == 30)
            //{
            //    Console.WriteLine($"{i}:THIRTY");
            //}
            //else
            //{ 
            //    Console.WriteLine($"{i}:NOT 10 20 or 30");
            //}

            ////switch
            //i = 30;
            //switch(i)
            //{
            //    case 10:
            //        Console.WriteLine($"{i} : TEN");
            //        break;
            //    case 20:
            //        Console.WriteLine($"{i} : TWENTY");
            //       break;

            //    default:
            //        Console.WriteLine($"{i} : NOT 10 20 or 30");
            //        break;
            //    case 30:
            //        Console.WriteLine($"{i} : THIRTY");
            //        break;




            int e = 30, r = 10;
            if (e > r)
            {
                Console.WriteLine("{e} is greater than {r}");
            }
            else if (r > e)
            {
                Console.WriteLine("{r} is grater than {e}");
            }
            else
            {
                Console.WriteLine("{e} and {r} is equal");
            }

            Console.ReadLine();
        }

















        






        }
    }


