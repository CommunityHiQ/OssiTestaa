﻿using System.ComponentModel;
using System.Linq;
using System.Threading;
using Microsoft.CSharp; // You can remove this if you don't need dynamic type in .Net Standard tasks

#pragma warning disable 1591

namespace namespaceForTask
{
    public static class classNameForTask
    {
        /// <summary>
        /// This is task
        /// Documentation: https://github.com/CommunityHiQ/namespaceForTask
        /// </summary>
        /// <param name="input">What to repeat.</param>
        /// <param name="options">Define if repeated multiple times. </param>
        /// <param name="cancellationToken"></param>
        /// <returns>{string Replication} </returns>
        public static Result TaskName(Parameters input, [PropertyTab] Options options, CancellationToken cancellationToken)
        {
            var repeats = new string[options.Amount];

            for (var i = 0; i < options.Amount; i++)
            {
                // It is good to check cancellation token somewhere you spend lot of time, e.g. in loops.
                cancellationToken.ThrowIfCancellationRequested();

                repeats[i] = input.Message;
            }

            var output = new Result
            {
                Replication = string.Join(options.Delimiter, repeats)
            };

            return output;
        }

    }
}
