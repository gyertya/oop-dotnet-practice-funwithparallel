using System;
using System.Collections.Generic;

namespace SomeParallelFun
{
    internal class Simulation
    {
        /// <summary>
        /// This program shows the differencies between Foreach and Parallel.Foreach
        /// </summary>
        /// <param name="args"></param>
        internal Simulation(int listSize, int forLoopDelay)
        {
            Loops loops = new Loops
            {
                ListOfSomething = new List<int>(),
                ForLoopDelay = forLoopDelay
            };

            FillUpList(loops, listSize);

            ForMethod normalFor = loops.NormalFor;
            ForMethod parallelFor = loops.ParallelFor;

            Console.WriteLine("\nNormal foreach:");
            var NormalForTime = Stopper.Runtime(normalFor);

            Console.WriteLine("\nParallel foreach:");
            var ParalelForTime = Stopper.Runtime(parallelFor);

            PrintOutResult(NormalForTime, ParalelForTime, loops.ForLoopDelay);
        }

        private void FillUpList(Loops loops, int listSize)
        {

            for (int i = 0; i < listSize; i++)
            {
                loops.ListOfSomething.Add(i + 1);
            }
        }

        private void PrintOutResult(TimeSpan NormalForTime, TimeSpan ParalelForTime, int delay)
        {
            var prop = (double)NormalForTime.TotalMilliseconds / ParalelForTime.TotalMilliseconds;
            Console.WriteLine(
                $"\n\n\nTime for the normal loop:   {NormalForTime.TotalMilliseconds,15}ms\n" +
                $"Time for the parallel loop: {ParalelForTime.TotalMilliseconds,15}ms\n" +
                $"\tDelay: {delay}ms" + 
                $"You have {Environment.ProcessorCount} processor(s) and the result proportion is: {prop}");
        }
    }
}
