using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_StringType
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string name = "Farin";
            Console.WriteLine(name);

            Console.WriteLine(name.Length);

            name = "       Farin";
            Console.WriteLine(name);
            Console.WriteLine(name.Trim());

            name = "Farin";
            Console.WriteLine(name.ToUpper());//FARIN
            Console.WriteLine(name.ToLower());//farin

            name = "\"Farin\"";//    this \ have a meaning
            Console.WriteLine(name); // "Farin"

            name = "\'Farin\'";
            Console.WriteLine(name);

            name = "\\Farin\\";
            Console.WriteLine(name); // \Farin\

            Console.WriteLine("sabiha inamdar");
            Console.WriteLine("sabiha\tinamdar");// three spaces
            Console.WriteLine("sabiha\ninamdar");// for next line

            // string path = "E:\\temp\\Batch22\\Client";
            string path = @"E:\temp\Batch22\Client";
            Console.WriteLine(path); //@ is a verbatin letral to finding the meaning of \ in path

            string firstName = "Farin";
            string lastName = "Jakate";
            string fullName = firstName + lastName;
            Console.WriteLine(fullName); // FarinJakate

            fullName = firstName + " " + lastName;
            Console.WriteLine(fullName); // Farin Jakate

            fullName = string.Concat(firstName, " ", lastName);
            Console.WriteLine(fullName); // Farin Jakate

            string middleName = "shahanur";
            fullName = string.Concat(firstName + " " + middleName + " " + lastName);
            Console.WriteLine(fullName); // Farin shahanur jakate

            fullName = string.Join(" ", firstName, middleName, lastName);
            Console.WriteLine(fullName); // Farin shahanur Jakate

            

            fullName = string.Join(" ", "Full", "Name", ":", firstName, middleName, lastName);
            Console.WriteLine(fullName);//// Full Name : Farin shahanur Jakate

            // placeholder syntax
            fullName = string.Format("Full Name : {0} {1} {2}", firstName, middleName, lastName);
            Console.WriteLine(fullName);//Full Name : Farin shahanur Jakate

            // string interpolation
            fullName = $"Full Name : {firstName} {middleName}\t, {lastName}";
            Console.WriteLine(fullName);//Full Name : Farin shahanur      , Jakate

            fullName = $"My Son Name Is : {firstName}";
            Console.WriteLine(fullName);//My Son Name Is : Farin

            Console.ReadLine();







        }
    }
}
