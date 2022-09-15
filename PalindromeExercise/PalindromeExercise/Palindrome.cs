using System;
using System.Collections.Generic;
using System.Text;


namespace PalindromeExercise
{
    public class Palindrome
    {
        public bool IsAPalindrome(string word)
        {
            var reversed = "";
            for (int i = word.Length - 1; i >= 0; i--)
            {
                reversed += word[i];
            }
            if(reversed == word)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
