using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var detector = new FizzBuzzDetector();

            var result = detector.GetOverlappings("Mary had a little lamb");

            Console.WriteLine(result.OutputString);
            Console.WriteLine(result.Count);
        }
    }
}
