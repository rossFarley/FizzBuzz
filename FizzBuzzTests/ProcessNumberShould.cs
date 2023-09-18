using FizzBuzz;
using Xunit;

namespace FizzBuzzTests
{
    public class ProcessNumberShould
    {
        [Fact]
        public void ReturnFizzBuzz()
        {
            NumberCruncher numberCruncher = new NumberCruncher();
            Assert.True(numberCruncher.CheckNumber(15) == Constants.FIZZBUZZ);
        }

        [Fact]
        public void ReturnFizz()
        {
            NumberCruncher numberCruncher = new NumberCruncher();
            Assert.True(numberCruncher.CheckNumber(3) == Constants.FIZZ);
        }

        [Fact]
        public void ReturnBuzz()
        {
            NumberCruncher numberCruncher = new NumberCruncher();
            Assert.True(numberCruncher.CheckNumber(5) == Constants.BUZZ);
        }

        [Fact]
        public void ReturnNumber()
        {
            int number = 2;
            NumberCruncher numberCruncher = new NumberCruncher();
            Assert.True(numberCruncher.CheckNumber(2) == number.ToString());
        }
    }
}
