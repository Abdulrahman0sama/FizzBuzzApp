using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzApp
{
    /// <summary>
    /// Represents the result of the FizzBuzz detection process.
    /// </summary>
    public class Result
    {
        /// <summary>
        /// The processed output string.
        /// </summary>
        public string OutputString { get; set; }

        /// <summary>
        /// Total number of Fizz, Buzz, and FizzBuzz replacements.
        /// </summary>
        public int Count { get; set; }
    }
}
