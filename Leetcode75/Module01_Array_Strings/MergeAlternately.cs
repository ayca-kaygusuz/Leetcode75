// see end of the file for problem description

namespace MergeAlternately
{
    public static class MergeAlternatelySolution
    {
        public static string MergeAlternately(string word1, string word2)
        {
            string merged = "";

            if (word1.Length == word2.Length)
            {
                // if the words are equal length,
                // we simply add each letter to the
                // returned variable in turns
                for (int i = 0; i < word1.Length; i++)
                {
                    merged += word1[i];
                    merged += word2[i];
                }
            }
            else if (word1.Length > word2.Length)
            {
                // if the first word is longer, the excess will certainly be at the end
                // so we merge whatever's equal normally by calling this function
                // for the same length substrings
                merged = MergeAlternately(word1.Substring(0, word2.Length), word2);
                // once the same length substrings of both words are merged, 
                // append word 1's excess 
                merged += word1.Substring(word2.Length, word1.Length - word2.Length);
            }
            else
            {
                // if the second word is longer, this time it's word2 that will be
                // trimmed to word1's length before calling this function
                merged = MergeAlternately(word1, word2.Substring(0, word1.Length));
                // afterward, append word2's excess
                merged += word2.Substring(word1.Length, word2.Length - word1.Length);
                // uneven words are handled in two cases to preserve the word order
                // without hoarding resources
            }

            return merged;
        }
    }
}


/*
1768. Merge Strings Alternately
Solved
Easy
Topics
Companies
Hint

You are given two strings word1 and word2. Merge the strings by adding letters in alternating order, starting with word1. If a string is longer than the other, append the additional letters onto the end of the merged string.

Return the merged string.

 

Example 1:

Input: word1 = "abc", word2 = "pqr"
Output: "apbqcr"
Explanation: The merged string will be merged as so:
word1:  a   b   c
word2:    p   q   r
merged: a p b q c r

Example 2:

Input: word1 = "ab", word2 = "pqrs"
Output: "apbqrs"
Explanation: Notice that as word2 is longer, "rs" is appended to the end.
word1:  a   b 
word2:    p   q   r   s
merged: a p b q   r   s

Example 3:

Input: word1 = "abcd", word2 = "pq"
Output: "apbqcd"
Explanation: Notice that as word1 is longer, "cd" is appended to the end.
word1:  a   b   c   d
word2:    p   q 
merged: a p b q c   d

 

Constraints:

    1 <= word1.length, word2.length <= 100
    word1 and word2 consist of lowercase English letters.
*/