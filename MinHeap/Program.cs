﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinHeap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MinHeap minHeap = new MinHeap();

            minHeap.Add(1);
            minHeap.Add(2);
            minHeap.Add(5);
            minHeap.Add(4);
            minHeap.Add(3);
            minHeap.Add(9);
            minHeap.Add(6);
            Console.WriteLine(minHeap.ToString());

            Console.WriteLine($"\nMin: {minHeap.GetMin()}\n");

            Console.WriteLine(minHeap.ToString());
            Console.ReadKey();
        }
    }
}
