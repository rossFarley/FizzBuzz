using FizzBuzz;
using Xunit;

namespace FizzBuzzTests
{
    public class ProcessTenNumberRangeShould
    {
        private int _min = 1;
        private int _max = 10;

        [Fact]
        public void ReturnTenResults()
        {
            NumberCruncher numberCruncher = new NumberCruncher();
            List<string> results = numberCruncher.CheckNumberRange(_min, _max);
            Assert.True(results.Count == 10);
        }

        [Fact]
        public void ReturnNoFizzBuzz()
        {
            NumberCruncher numberCruncher = new NumberCruncher();
            List<string> results = numberCruncher.CheckNumberRange(_min, _max);
            Assert.True(results.Where(p => p == Constants.FIZZBUZZ).Count() == 2);
        }

        [Fact] 
        public void ReturnTwoBuzz() 
        {
            NumberCruncher numberCruncher = new NumberCruncher();
            List<string> results = numberCruncher.CheckNumberRange(_min, _max);
            Assert.True(results.Where(p => p == Constants.BUZZ).Count() == 2);
        }

        [Fact]
        public void ReturnThreeFizz()
        {
            NumberCruncher numberCruncher = new NumberCruncher();
            List<string> results = numberCruncher.CheckNumberRange(_min, _max);
            Assert.True(results.Where(p => p == Constants.FIZZ).Count() == 3);
        }

        [Fact]
        public void ReturnFiveNumbers()
        {
            NumberCruncher numberCruncher = new NumberCruncher();
            List<string> results = numberCruncher.CheckNumberRange(_min, _max);
            Assert.True(results.Where(p => p != Constants.FIZZ && p != Constants.BUZZ && p != Constants.FIZZBUZZ).Count() == 5);
        }
    }
}
