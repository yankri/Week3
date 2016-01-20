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
            //arrays powerpoint

            string[] daysOfTheWeek = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

            int[] studentAges = new int[14] { 29, 25, 20, 40, 50, 37, 31, 14, 90, 45, 32, 30, 58, 40 };

            Console.WriteLine(studentAges.Min());
            Console.WriteLine(studentAges[7]);
            Console.WriteLine(studentAges.Max());
            Console.WriteLine(studentAges[8]);

            Console.WriteLine(daysOfTheWeek.Length);

            Console.WriteLine();
            string lastName = "Scholdberg";
            char[] lastNametoChar = lastName.ToCharArray();
            Console.WriteLine(lastNametoChar.Length);

            string[] stringArray = { "kitties", "puppies", "raccoons", "foxes" };
            Console.WriteLine(stringArray[stringArray.Length - 2]);

            string[] birthMonths = { "October", "July", "October", "May" };
            Console.WriteLine(Array.IndexOf(birthMonths, "October"));

            string[] firstNames = { "Krista", "Ashley", "Lauren", "Fred" };
            Console.WriteLine(Array.IndexOf(firstNames, "Fred"));

            int[] numbers = { 2, 5, 9, 4, 3, 4, 6, 5 };
            Console.WriteLine(Array.LastIndexOf(numbers, 4));

            int[] luckies = { 44, 67, 45, 43, 4, 14, 44, 45, 4, 43, 67, 14 };
            Console.WriteLine(Array.LastIndexOf(luckies, 44));

            Array.Reverse(numbers);
            Console.WriteLine(numbers[0]);

            char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f' };
            Array.Reverse(letters);
            Console.WriteLine(letters[0]);

            int[] numbers2 = { 5, 2, 9, 4, 3, 6, 5 };
            Array.Sort(numbers2);
            Console.WriteLine(numbers2[0]);

            string[] names = { "John", "Bob", "Joe", "Jerry" };
            Array.Sort(names);
            Console.WriteLine(names[0]);
            Console.WriteLine(names[names.Length - 1]);

            int[] favNums = { 44, 17, 89, 46, 34, 12, 0, 5, 10, 27 };
            Array.Sort(favNums);
            Console.WriteLine(favNums[0]);
            Console.WriteLine(favNums[favNums.Length - 1]);

            string[] days = { "Mon", "Tue", "Wed", "Thur", "Fri", "Sat", "Sun" };
            int i; 

            for (i = 0; i < days.Length; i++)
            {
                Console.WriteLine(days[i]);
            }

        }
    }
}
