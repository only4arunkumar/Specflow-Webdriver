using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyRCP.Helpers
{
    public static class Timed
    {
        /// <summary>
        /// Execute action then invoke reporting action with elapsed time
        /// </summary>
        /// <param name="timedAction">action to be executed and elapsed time measured</param>
        /// <param name="reportAction">action to be executed with the elapsed number of milliseconds passed as a parameter</param>
        /// <returns>number of milliseconds elapsed during timedAction</returns>
        public static long Execute(Action timedAction, Action<long> reportAction)
        {
            var stopwatch = new System.Diagnostics.Stopwatch();

            stopwatch.Start();
            timedAction();
            stopwatch.Stop();

            var elapsedMilliseconds = stopwatch.ElapsedMilliseconds;

            if (reportAction != null)
            {
                reportAction(elapsedMilliseconds);
            }

            return elapsedMilliseconds;
        }

        /// <summary>
        /// Invoke specified action and return number of milliseconds elapsed
        /// </summary>
        /// <param name="timedAction">timed action to be executed</param>
        /// <returns>number of milliseconds elapsed</returns>
        public static long Execute(Action timedAction)
        {
            return Timed.Execute(timedAction, null);
        }
    }
}
