﻿using System;
using System.Threading;
namespace Chapter1
{
    public static class Program
    {
        public static void Main()
        {
            ThreadPool.QueueUserWorkItem((s) =>
            {
                Console.WriteLine("Working on a thread from threadpool");
            });
            Console.ReadLine();
        }
    }
}