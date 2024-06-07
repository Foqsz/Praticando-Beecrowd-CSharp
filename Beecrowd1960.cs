////MÉTODO UM/////

using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(ConvertToRoman(n));
        }

        static string ConvertToRoman(int n)
        {
            string result = "";

            while (n > 0)
            {
                if (n >= 1000) { result += "M"; n -= 1000; }
                else if (n >= 900) { result += "CM"; n -= 900; }
                else if (n >= 500) { result += "D"; n -= 500; }
                else if (n >= 400) { result += "CD"; n -= 400; }
                else if (n >= 100) { result += "C"; n -= 100; }
                else if (n >= 90) { result += "XC"; n -= 90; }
                else if (n >= 50) { result += "L"; n -= 50; }
                else if (n >= 40) { result += "XL"; n -= 40; }
                else if (n >= 10) { result += "X"; n -= 10; }
                else if (n >= 9) { result += "IX"; n -= 9; }
                else if (n >= 5) { result += "V"; n -= 5; }
                else if (n >= 4) { result += "IV"; n -= 4; }
                else if (n >= 1) { result += "I"; n -= 1; }
            }

            return result;
        }
    }
}


/// MÉTODO DOIS/////

using System; 

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); 

            while (n > 0)
            {
                if (n >= 1000)
                {
                    Console.Write("M");
                    n -= 1000;
                }
                else if (n >= 900)
                {
                    Console.Write("CM");
                    n -= 900;
                }
                else if (n >= 500)
                {
                    Console.Write("D");
                    n -= 500;
                }
                else if (n >= 400)
                {
                    Console.Write("CD");
                    n -= 400;
                }
                else if (n >= 100)
                {
                    Console.Write("C");
                    n -= 100;
                }
                else if (n >= 90)
                {
                    Console.Write("XC");
                    n -= 90;
                }
                else if (n >= 50)
                {
                    Console.Write("L");
                    n -= 50;
                }
                else if (n >= 40)
                {
                    Console.Write("XL");
                    n -= 40;
                }
                else if (n >= 10)
                {
                    Console.Write("X");
                    n -= 10;
                }
                else if (n >= 9)
                {
                    Console.Write("IV");
                    n -= 9;
                }
                else if (n >= 5)
                {
                    Console.Write("V");
                    n -= 5;
                }
                else if (n >= 4)
                {
                    Console.Write("IV");
                    n -= 4;
                }
                else if (n >= 1)
                {
                    Console.Write("I");
                    n -= 1;
                } 
            }
        }
    }
}
