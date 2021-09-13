using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("hello", false)]
        [InlineData("kayak", true)]
        [InlineData("abba", true)]
        [InlineData("queen", false)]
        public void Test1(string word, bool expected)
        {
            //Arrange
            var test = new WordSmith();
            //Act
            var actual = test.IsAPalindrome(word);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
