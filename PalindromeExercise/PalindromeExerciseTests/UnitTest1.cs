using System;
using Xunit;
using PalindromeExercise;
namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("kayak", true)]
        [InlineData("hannah", true)]
        [InlineData("racecar", true)]
        [InlineData("radar", true)]
        [InlineData("joy", false)]
        [InlineData("ant", false)]

        public static void IsAPalindromeTest(string word, bool expected)
        {
            var ws = new WordSmith();

            var actual = WordSmith.IsAPalindrome(word);

            Assert.Equal(expected, actual);
        }
    }
}
