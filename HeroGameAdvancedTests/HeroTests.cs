using System;
using Xunit;
using HeroGameAdvancedLib;

namespace HeroGameAdvancedTests
{
    public class HeroTests
    {
        [Theory]
        [InlineData(2, 3, 1)]//PASS
        [InlineData(7, 2, -1)]//FAIL, should be = to -1
        [InlineData(2, 2, -1)]//FAIL, Uses = 0, should change to -1
        public void UsesTest(int attackNum, int uses, int expectedUses)
        {
            var hero = new Hero(1, "dion", new Dice(1, 6), uses);


            hero.Attack(attackNum);
            Assert.Equal(expectedUses, hero.Uses);
        }
    }
}
