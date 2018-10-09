using System;
using System.Collections.Generic;

namespace SomeParallelFun
{
    delegate void ForMethod();

    partial class Program
    {        
        static void Main(string[] args)
        {
            Simulation simulation = new Simulation(100, 16);
        }
    }
}
