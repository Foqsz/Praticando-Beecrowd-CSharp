using System;
using System.Collections.Generic;
using System.Linq;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                string conversaoUtilizada = Console.ReadLine();
                string[] RGB = Console.ReadLine().Split(' ');
                double R = double.Parse(RGB[0]);
                double G = double.Parse(RGB[1]);
                double B = double.Parse(RGB[2]); 

                if (conversaoUtilizada == "min")
                {
                    double minValue = Math.Min(R, Math.Min(G, B));
                    Console.WriteLine($"Caso #{i + 1}: {(int)minValue}");
                }
                else if (conversaoUtilizada == "mean")
                {
                    double media = (R + G + B) / 3;
                    Console.WriteLine($"Caso #{i + 1}: {(int)media}");
                }
                else if (conversaoUtilizada == "max")
                {
                    double maxValue = Math.Max(R, Math.Max(G, B));
                    Console.WriteLine($"Caso #{i + 1}: {(int)maxValue}");
                }
                else // Assume "eye" conversion
                {
                    double resultEye = (0.30 * R) + (0.59 * G) + (0.11 * B);
                    Console.WriteLine($"Caso #{i + 1}: {(int)resultEye}");
                }
            }
        }
    }
}
