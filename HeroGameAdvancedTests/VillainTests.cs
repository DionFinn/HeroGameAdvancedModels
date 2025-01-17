using System;
using Xunit;
using HeroGameAdvancedLib;

namespace HeroGameAdvancedTests
{
    public class VillainTests
    {
        [Theory]
        [InlineData(3, 4, 1)]//PASS
        [InlineData(3, 1, 0)]//PASS = 0 
        [InlineData(-3, 2, 0)]//ALL PASS
        public void DamageTest(int damageNum,  int hitpoints, int expected)
        {
            var villain = new Villain(1, "BadGuy", hitpoints);

            villain.Damage(damageNum);
            Assert.Equal(expected, villain.Hitpoints);
        }
    }
}
