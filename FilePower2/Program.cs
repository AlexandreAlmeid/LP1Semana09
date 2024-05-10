using System;
using System.Collections.Generic;
using System.IO;

namespace FilePower1
{
    class Program
    {
        static void Main(string[] args)
        {
            using StreamWriter file = new StreamWriter(args[0]);
            string line;
            while (true)
            {
                line = Console.ReadLine();
                if (String.IsNullOrEmpty(line))
                {
                    break;
                }
                file.WriteLine(line);
            }
        }
    }
}
