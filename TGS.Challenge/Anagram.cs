using System;
using System.Collections.Generic;

namespace TGS.Challenge
{
  /*
        Devise a function that checks if 1 word is an anagram of another, if the words are anagrams of
        one another return true, else return false

        "Anagram": An anagram is a type of word play, the result of rearranging the letters of a word or
        phrase to produce a new word or phrase, using all the original letters exactly once; for example
        orchestra can be rearranged into carthorse.

        areAnagrams("horse", "shore") should return true
        areAnagrams("horse", "short") should return false

        NOTE: Punctuation, including spaces should be ignored, e.g.

        horse!! shore = true
        horse  !! shore = true
          horse? heroes = true

        There are accompanying unit tests for this exercise, ensure all tests pass & make
        sure the unit tests are correct too.
     */
    public class Anagram
    {
      public bool AreAnagrams(string word1, string word2)
      {
            Dictionary<char, int> hash = new Dictionary<char, int>();

            if (string.IsNullOrWhiteSpace(word1))
                throw new ArgumentException("Word1 is required");

            if (string.IsNullOrWhiteSpace(word2))
                throw new ArgumentException("Word2 is required");

            word1 = word1.ToUpper();
            word2 = word2.ToUpper();

            for(int i = 0; i < word1.Length; i++)
            {
                if (word1[i] < 'A' || word1[i] > 'Z')
                    continue;
                
                if (hash.ContainsKey(word1[i]))
                    hash[word1[i]]++;
                else
                    hash.Add(word1[i], 1);
            }

            for (int i = 0; i < word2.Length; i++)
            {
                if (word2[i] < 'A' || word2[i] > 'Z')
                    continue;

                if (!hash.ContainsKey(word2[i]))
                    break;

                hash[word2[i]]--;

                if (hash[word2[i]] == 0)
                    hash.Remove(word2[i]);
            }

            return !(hash.Count > 0);
      }
    }
}
