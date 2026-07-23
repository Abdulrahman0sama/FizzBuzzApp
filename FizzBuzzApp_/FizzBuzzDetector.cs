using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzApp
{
    /// <summary>
    /// Detects Fizz, Buzz, and FizzBuzz words based on their position in the input text.
    /// </summary>
    public class FizzBuzzDetector
    {
        /// <summary>
        /// Processes a single word and appends either the original word,
        /// Fizz, Buzz, or FizzBuzz to the output.
        /// </summary>
        /// <param name="currentWord">The current word being processed.</param>
        /// <param name="outputStringBuilder">The output text builder.</param>
        /// <param name="index">Current word index.</param>
        /// <param name="count">Number of Fizz, Buzz, and FizzBuzz replacements.</param>
        private void ProcessWord(StringBuilder currentword, StringBuilder outputStringBuilder, ref int index, ref int count)
        {

            string word = currentword.ToString();
            index++;

            if (index % 3 == 0 && index % 5 == 0)
            {
                outputStringBuilder.Append("FizzBuzz");
                count++;

            }
            else if (index % 3 == 0)
            {
                outputStringBuilder.Append("Fizz");
                count++;
            }
            else if (index % 5 == 0)
            {
                outputStringBuilder.Append("Buzz");
                count++;
            }
            else
            {
                outputStringBuilder.Append(word);
            }
            currentword.Clear();

        }

        /// <summary>
        /// Replaces every third word with Fizz, every fifth word with Buzz,
        /// and every fifteenth word with FizzBuzz.
        /// </summary>
        /// <param name="input">Input text to process.</param>
        /// <returns>
        /// A <see cref="Result"/> object containing the processed text
        /// and the total number of Fizz, Buzz, and FizzBuzz replacements.
        /// </returns>
        public Result GetOverlappings(string input)
        {

            StringBuilder currentword = new StringBuilder();
            StringBuilder outputStringBuilder = new StringBuilder();

            int index = 0;
            int count = 0;
            if (input == null)
            {
                throw new ArgumentNullException(nameof(input));
            }
            foreach (char c in input)
            {
                if (char.IsLetterOrDigit(c))
                {
                    currentword.Append(c);
                }
                else
                {
                    if (currentword.Length > 0)
                    {
                        ProcessWord(currentword, outputStringBuilder, ref index, ref count);

                    }
                    outputStringBuilder.Append(c);

                }

            }
            if (currentword.Length > 0)
            {
                ProcessWord(currentword, outputStringBuilder, ref index, ref count);
            }
            return new Result
            {
                OutputString = outputStringBuilder.ToString(),
                Count = count
            };
        }
    }
}
