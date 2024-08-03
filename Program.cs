using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_TypeConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 10, j = 10;
            Console.WriteLine(i + j);
            //20

            //int=>string
            string a = i.ToString();
            string b = j.ToString();
            Console.WriteLine(a + b);


            byte b1 = 10;
            short s1 = b1;//byte->short
            Console.WriteLine(s1);//10

            float f1 = s1; //short to float
            Console.WriteLine(f1);//10

            //int i1 = f1; // float -> int
            int i1 = (int)f1;// due to loss of data thats why explicit conversion
            Console.WriteLine(f1);
             
            f1 = 25.55f;
            i1 = (int)f1;//float->int
            Console.WriteLine(i1);//25

            string s = "100";
            // i1 =(int) s;// string ->int
            i1 = Convert.ToInt32(s);//convert class
            Console.WriteLine(i1);//100

            s = "true"; 
            bool bb = Convert.ToBoolean(s);//string->bool
            Console.WriteLine(bb);


            
            //parse() method throws error when string is not in correct format
            s = "777";
            i1 = int.Parse(s);//string->int
            Console.WriteLine(i1);//777
            
            // s = "XYZ";
            //i1 = int.Parse(s);//runtime error
            //Console.WriteLine(i1);

            //TryParse() -> it hadles the runtime error
            /*Convert and return Conversion status along with converted
            value .
            in case of runtime error it returns false as a status 
            and default value as output
            default value of bool is false
            default value of int is 0
            default value of string is null*/

            s = "2000";
            bb = int.TryParse(s, out i1);
            Console.WriteLine($"Status :{bb} Result :{i1}");
            //Status :True Result :2000


            s = "XYZ";
            bb = int.TryParse(s, out i1);
            Console.WriteLine($"Status :{bb} Result :{i1}");
            //Status :False Result :0

            s = "ABC";
            bb = int.TryParse(s, out i1);
            Console.WriteLine($"Status :{bb} Result :{i1}");

            s = "true";
            bool b3 = Convert.ToBoolean(s);
            Console.WriteLine(b3);



            s = "true";
            bool b4 = Convert.ToBoolean(s);
            Console.WriteLine(b4);





            decimal X = 10;
            long l = (long)X;//decimal ->long
            Console.WriteLine(l);//10



            Console.ReadLine();







        }
    }
}
