using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace ConsoleApplication45
{
    class Numbers
    {
   
        public static int findminimum2(int num1, int num2)
        {
            int min = num2;
            if (num1 < num2) { min = num1; }
            return min;
        }

        public static int findmax(int num1, int num2)
        {
            int max = num2;
            if (num2 > num1) { max = num2; }
            return max;
        }
    }
 
 
 
class testnumber
    {
        static void Main(string[] args)
        {
            int min;
            min = Numbers.findminimum2(1, 6);
            int max =Numbers.findmax(1, 6);
            Console.WriteLine(" Minimum Value is : " + min);

            Console.WriteLine(" Maximum Value is : " + max);
            Console.Read();
        }
    }
}
