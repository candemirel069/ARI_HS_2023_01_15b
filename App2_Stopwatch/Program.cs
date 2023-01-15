using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace App2_Stopwatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Stopwatch stopwatch = new Stopwatch();
            //stopwatch.Start();
            Stopwatch stopwatch = Stopwatch.StartNew();
            var lst = new List<string>();
            for (int i = 0; i < 100000; i++)
            {
                lst.Add(Guid.NewGuid().ToString());
            }
            lst.Sort();
            stopwatch.Stop();

            Console.WriteLine(stopwatch.ElapsedMilliseconds+"ms");
        }
    }
}
