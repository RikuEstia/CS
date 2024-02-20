using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14;
            double radius;
            
            // Read the radius from the user input
            radius = Convert.ToDouble(Console.ReadLine());

            // Calculate the area
            double output = pi * radius * radius;

            // Output the result
            Console.WriteLine(output);
        }
    }
}
