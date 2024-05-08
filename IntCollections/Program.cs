using System;
using System.Collections.Generic;

namespace IntCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>(){1,10,-30,10,-5};
            Stack<int> pilha = new Stack<int>();
            Queue<int> fila = new Queue<int>();
            HashSet<int> hash = new HashSet<int>();

            // Lista
            Console.Write("List:");
            foreach (int i in lista)
            {
                Console.Write($" {i}");
                pilha.Push(i);
                fila.Enqueue(i);
                hash.Add(i);
            }
            Console.WriteLine("");

            // Pilha
            Console.Write("Stack:");
            foreach (int i in pilha)
            {
                Console.Write($" {i}");
            }
            Console.WriteLine("");

            // Fila
            Console.Write("Queue:");
            foreach (int i in fila)
            {
                Console.Write($" {i}");
            }
            Console.WriteLine("");

            // Hash
            Console.Write("HashSet:");
            foreach (int i in hash)
            {
                Console.Write($" {i}");
            }
            Console.WriteLine("");
        }
    }
}
