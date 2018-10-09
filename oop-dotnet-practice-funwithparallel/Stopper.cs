using System;

namespace SomeParallelFun
{
    class Stopper
    {
        /// <summary>
        /// Calculate the method's running time
        /// </summary>
        /// <param name="forMethod"></param>
        /// <returns></returns>
        public static TimeSpan Runtime(ForMethod forMethod)
        {
            var start = DateTime.Now;
            forMethod();
            var stop = DateTime.Now;

            return stop-start;
        }
    }
}
