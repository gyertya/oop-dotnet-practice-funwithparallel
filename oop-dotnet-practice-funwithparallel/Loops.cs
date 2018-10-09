using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SomeParallelFun
{
    class Loops
    {
        internal List<int> ListOfSomething { get; set; }
        internal int ForLoopDelay { get; set; }

        /// <summary>
        /// Print out the list to the screen with a delay. Uses Paralell.ForEach.
        /// </summary>
        internal void ParallelFor()
        {
            Parallel.ForEach(ListOfSomething, item =>
            {
                PrintAndWait(item);
            });
        }

        /// <summary>
        /// Print out the list to the screen with a delay. Uses normal ForEach.
        /// </summary>
        internal void NormalFor()
        {
            foreach (var item in ListOfSomething)
            {
                PrintAndWait(item);
            }
        }

        private void PrintAndWait(int item)
        {
            Console.Write(item + " ");
            System.Threading.Thread.Sleep(ForLoopDelay);
        }
    }


}

