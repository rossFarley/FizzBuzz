using FizzBuzz;
using Xunit;

namespace FizzBuzzTests
{
    public class ProcessOneHundredNumberRangeShould
    {
        private int _min = 1;
        private int _max = 100;

        [Fact]
        public void ReturnOneHundredResults()
        {
            NumberCruncher numberCruncher = new NumberCruncher();
            List<string> results = numberCruncher.CheckNumberRange(_min, _max);
            Assert.True(results.Count == 100);
        }

        [Fact]
        public void ReturnFourteenBuzz()
        {
            NumberCruncher numberCruncher = new NumberCruncher();
            List<string> results = numberCruncher.CheckNumberRange(_min, _max);
            Assert.True(results.Where(p => p == Constants.BUZZ).Count() == 14);
        }

        [Fact]
        public void ReturnTwentySevenFizz()
        {
            NumberCruncher numberCruncher = new NumberCruncher();
            List<string> results = numberCruncher.CheckNumberRange(_min, _max);
            Assert.True(results.Where(p => p == Constants.FIZZ).Count() == 27);
        }

        [Fact]
        public void ReturnSixFizzBuzz()
        {
            NumberCruncher numberCruncher = new NumberCruncher();
            List<string> results = numberCruncher.CheckNumberRange(_min, _max);
            Assert.True(results.Where(p => p == Constants.FIZZBUZZ).Count() == 6);
        }

        [Fact]
        public void ReturnFiftyThreeNumbers()
        {
            NumberCruncher numberCruncher = new NumberCruncher();
            List<string> results = numberCruncher.CheckNumberRange(_min, _max);
            Assert.True(results.Where(p => p != Constants.FIZZ && p != Constants.BUZZ && p != Constants.FIZZBUZZ).Count() == 53);
        }
    }
}
