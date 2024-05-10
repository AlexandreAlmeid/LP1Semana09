using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CharSets
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<char>[] filesets = new HashSet<char>[args.Length];
            string[] lines;
            for (int i = 0; i < args.Length; i++)
            {
                filesets[i] = new HashSet<char>();
                lines = File.ReadAllLines(args[i]);
                foreach (string line in lines)
                {
                    if (line.Length > 1)
                    {
                        Environment.ExitCode = -1;
                    }
                    filesets[i].Add(Char.Parse(line));
                }
            }
            HashSet<char> result = filesets[0];
            foreach (HashSet<char> set in filesets)
            {
                result.IntersectWith(set);
            }
            List<char> final = result.ToList();
            final.Sort();
            foreach (char c in final)
            {
                Console.WriteLine(c);
            }
        }
    }
}
