using System;
using System.Linq;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string word)
        {
            var result = word.SequenceEqual(word.Reverse()) ? true : false;
            return result;
        }
    }
}
