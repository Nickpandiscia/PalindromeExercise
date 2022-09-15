using System;
using Xunit;
using PalindromeExercise;
using Microsoft.VisualStudio.TestPlatform.Common.Interfaces;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("hello", false)]
        public void MyWord(string word, bool expected)
        {
            var theTest = new Palindrome();
            var actual = theTest.IsAPalindrome(word);
            Assert.Equal(expected, actual);
        }
    }
}
