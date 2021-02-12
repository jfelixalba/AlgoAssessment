using System;
using System.Collections.Generic;

namespace TGS.Challenge
{
    /*
        Devise a function that takes a string & returns the number of 
        vowels (aeiou) in that string.

        "Hi there!" = 3
        "What do you mean?"  = 6

        There are accompanying unit tests for this exercise, ensure all tests pass & make
        sure the unit tests are correct too.
     */
    public class VowelCount
    {
        public int Count(string value)
        {
            HashSet<char> hash = new HashSet<char> { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            int vowels = 0;

            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("value is required");

            for(int i = 0; i < value.Length; i++)
            {
                if (hash.Contains(value[i]))
                    vowels++;
            }

            return vowels;
        }
    }
}
