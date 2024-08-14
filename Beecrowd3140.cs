using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            bool insideBody = false;

            string line;
            while ((line = Console.ReadLine()) != null)
            {
                if (line.Trim() == "<body>")
                {
                    insideBody = true;
                    continue;
                }

                if (line.Trim() == "</body>")
                {
                    insideBody = false;
                    continue;
                }

                if (insideBody)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
