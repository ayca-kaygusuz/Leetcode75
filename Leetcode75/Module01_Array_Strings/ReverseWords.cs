// see end of the file for problem description

namespace ReverseWords
{
    public class ReverseWordsSolution
    {
        // STATS:
        // Runtime Complexity: O(N)
        // Runtime beats 100% of submissions (checked 15 Jan 2025)
        // Memory Complexity: O(N)
        // Memory beats 54.10% of submissions (checked 15 Jan 2025)
        public string ReverseWords(string s)
        {
            // Step 1: Trim leading and trailing spaces and split words
            string[] words = s.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            // Step 2: Reverse the words array
            Array.Reverse(words);

            // Step 3: Join the words with a single space
            return string.Join(" ", words);
        }
    }

}

/*
151. Reverse Words in a String

Given an input string s, reverse the order of the words.

A word is defined as a sequence of non-space characters. The words in s will be separated by at least one space.

Return a string of the words in reverse order concatenated by a single space.

Note that s may contain leading or trailing spaces or multiple spaces between two words. The returned string should only have a single space separating the words. Do not include any extra spaces.

 

Example 1:

Input: s = "the sky is blue"
Output: "blue is sky the"

Example 2:

Input: s = "  hello world  "
Output: "world hello"
Explanation: Your reversed string should not contain leading or trailing spaces.

Example 3:

Input: s = "a good   example"
Output: "example good a"
Explanation: You need to reduce multiple spaces between two words to a single space in the reversed string.

 

Constraints:

    1 <= s.length <= 104
    s contains English letters (upper-case and lower-case), digits, and spaces ' '.
    There is at least one word in s.

 

Follow-up: If the string data type is mutable in your language, can you solve it in-place with O(1) extra space?

*/