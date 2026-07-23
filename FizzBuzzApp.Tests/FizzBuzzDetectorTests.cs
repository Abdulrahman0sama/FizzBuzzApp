using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzApp.Tests
{
    public class FizzBuzzDetectorTests
    {
        [Fact]
        public void ThirdWord_ShouldBeFizz()
        {
            var detector = new FizzBuzzDetector();

            var result = detector.GetOverlappings("one two three");

            Assert.Equal("one two Fizz", result.OutputString);
            Assert.Equal(1, result.Count);
        }


        [Fact]
        public void FifthWord_ShouldBeBuzz()
        {
            var detector = new FizzBuzzDetector();

            var result = detector.GetOverlappings("one two three four five");

            Assert.Equal("one two Fizz four Buzz", result.OutputString);
            Assert.Equal(2, result.Count);
        }

        [Fact]
        public void FifteenthWord_ShouldBeFizzBuzz()
        {
            var detector = new FizzBuzzDetector();

            var input =
                "one two three four five six seven eight nine ten eleven twelve thirteen fourteen fifteen";

            var result = detector.GetOverlappings(input);

            Assert.Contains("FizzBuzz", result.OutputString);
        }

        [Fact]
        public void EmptyString_ShouldReturnEmptyResult()
        {
            var detector = new FizzBuzzDetector();

            var result = detector.GetOverlappings("");

            Assert.Equal("", result.OutputString);
            Assert.Equal(0, result.Count);
        }

        [Fact]
        public void NullInput_ShouldThrowException()
        {
            var detector = new FizzBuzzDetector();

            Assert.Throws<ArgumentNullException>(() =>
            {
                detector.GetOverlappings(null);
            });
        }

    }
}
