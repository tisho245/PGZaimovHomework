﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("elementi na opashkata ");
            Queue<int> queue = new Queue<int>();
            for (int i = 0; i < 10; i++)
            {
                queue.Enqueue(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine("poledniq -"+ queue.Peek());
            Console.WriteLine("minimalniq -"+ queue.Min());
            
        }
    }
}
