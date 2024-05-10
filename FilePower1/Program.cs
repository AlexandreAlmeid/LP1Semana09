using System;
using System.Collections.Generic;
using System.IO;

namespace FilePower1
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> text = new Queue<string>();
            string line;
            while (true)
            {
                line = Console.ReadLine();
                if (String.IsNullOrEmpty(line))
                {
                    break;
                }
                text.Enqueue(line);
            }
            File.WriteAllLines(args[0], text);
        }
    }
}
