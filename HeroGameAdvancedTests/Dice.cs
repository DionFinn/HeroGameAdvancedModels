using System;
using Xunit;
using HeroGameAdvancedLib;

namespace HeroGameAdvancedTests
{
    public class DiceTests
    {
        [Theory(Skip = "skip")]
        [InlineData(2, 4)]//PASS
        [InlineData(-1, 11)]//PASS, negative is still in range 
        [InlineData(3, 3)]//PASS
        [InlineData(6, 3)]//FAIL, min value is higher than max value

        public void DiceTest(int min, int max)
        {
           var dice = new Dice(min, max);
           var actual = dice.Roll();
           
           Assert.InRange(actual, min, max);
        }
    }
}
