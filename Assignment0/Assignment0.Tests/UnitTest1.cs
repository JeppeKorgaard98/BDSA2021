using System;
using Xunit;

namespace Assignment0.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Is_leap_year_if_divisible_by_4()
        {
            bool exptected = true;
            bool acutal = Program.isLeapYear(40);    
            Assert.Equal(exptected, acutal);
            
        }
        [Fact]
        public void Is_not_leap_year_if_divisible_by_4_and_100()
        {
            bool exptected = false;
            bool acutal = Program.isLeapYear(1900);
            Assert.Equal(exptected, acutal);
        }
        [Fact]
        public void Is_leap_year_if_divisible_by_400()
        {
            bool exptected = true;
            bool acutal = Program.isLeapYear(2000);
            Assert.Equal(exptected, acutal);
        }
    }
}
