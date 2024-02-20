using System;
using System.Collections.Generic;


namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            
            //your code goes here
            
            for(int x=1;x<=number;x++)
            {
             if(x%3==0)
             {
                 
                 
                 Console.Write("*");
                 
             }
             else
             {
                 Console.Write(x);
             }
        }
    }
}
}
