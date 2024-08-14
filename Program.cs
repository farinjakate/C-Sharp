using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_NullableType
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //string name = "farin";
            //Console.WriteLine(name);//farin

            //name = null;
            //Console.WriteLine(name);// it does'nt printed anything

            //int? age = null;//non-nullable
            //bool? isDeliverd = null;//non-nullable
            //DateTime? dob = null;//non-nullable

            //Nullable<int> marks = null;//nullable

            ////int? = all int type values +null value

            //int? a = null;
            ////int b = (int)a;
            //int b = a ?? 0;
            //Console.WriteLine($"a:{a} b:{b}");

            ////string email = "farin@gmail.com";
            //string email = null;
            //string emailInUpper = email?.ToUpper();
            //Console.WriteLine($"email:{email} \nemail In Upper {emailInUpper}");



            ///int a = 10;//make it nullable
            int ? a = null;// ? means nullable ,null means absence of value
            int b = a ?? 0;// here convert nullable type to non nullable means ager null pass kiye to
                           //output 0 denga,ager value pass nahi kiye to user ke output ke liye wait arenga.
                           ////(null coalesce operator) kehete hai ise.
            Console.WriteLine($"a:{a}");

            string email = "FARINJAKATE786@GMAIL.COM";
           // string emailInUpper = email.ToUpper();
            string emailInLower = email.ToLower();

            Console.WriteLine($"email:{email} \n email In Upper:{emailInLower}");

           // Console.WriteLine($"email:{email} \n email In Upper:{emailInUpper}");


            Console.ReadLine();















        }
    }
}
