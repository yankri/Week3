using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] daysOfTheWeek = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

            int[] studentAges = new int[14] { 29, 25, 20, 40, 50, 37, 31, 14, 90, 45, 32, 30, 58, 40 };

            Console.WriteLine(studentAges.Min());
            Console.WriteLine(studentAges[7]);
            Console.WriteLine(studentAges.Max());
            Console.WriteLine(studentAges[8]);

            Console.WriteLine();
            string lastName = "Scholdberg";
            char[] lastNametoChar = lastName.ToCharArray();
            Console.WriteLine(lastNametoChar.Length);

            string[] stringArray = { "kitties", "puppies", "raccoons", "foxes" };
            Console.WriteLine(stringArray[stringArray.Length - 2]);
        }
    }
}
