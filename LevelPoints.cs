using System;
using System.Collections.Generic;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int levels = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Points(levels));
        }

        
        static int Points(int levels)
        {
        if (levels == 0)
        {
            return 0;
        }
        else
        {
            return levels + Points(levels - 1);
        }
        }
    }

}
