using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foreach_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomNoms = { "candy", "cupcakes", "ice cream", "donuts" };

            foreach (string nom in nomNoms)
            {
                Console.WriteLine(nom);
            }
        }
    }
}
