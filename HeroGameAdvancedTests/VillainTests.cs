using System;
using Xunit;
using HeroGameAdvancedLib;

namespace HeroGameAdvancedTests
{
    public class VillainTests
    {
        [Theory(Skip = "skip")]
        [InlineData(3, 4, 1)]//PASS
        [InlineData(3, 1, 0)]//PASS = 0 
        [InlineData(-3, 2, 0)]//FAIL negative value should not increase hitpoints
        public void DamageTest(int damageNum,  int hitpoints, int expected)
        {
            var villain = new Villain(1, "BadGuy", hitpoints);

            villain.Damage(damageNum);
            Assert.Equal(expected, villain.Hitpoints);
        }
    }
}
