// see end of the file for problem description

namespace ReverseVowels
{
    public class ReverseVowelsSolution
    {
        // STATS:
        // Runtime Complexity: O(N)
        // Runtime beats 56.78% of submissions (checked 15 Jan 2025)
        // Memory Complexity: O(N)
        // Memory beats 91.41% of submissions (checked 15 Jan 2025)
        public string ReverseVowels(string s)
        {
            HashSet<char> vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            char[] chars = s.ToCharArray();
            int left = 0, right = chars.Length - 1;

            while (left < right)
            {
                // Move left pointer until a vowel is found
                while (left < right && !vowels.Contains(chars[left]))
                {
                    left++;
                }
                // Move right pointer until a vowel is found
                while (left < right && !vowels.Contains(chars[right]))
                {
                    right--;
                }

                // Swap the vowels
                if (left < right)
                {
                    char temp = chars[left];
                    chars[left] = chars[right];
                    chars[right] = temp;
                    left++;
                    right--;
                }
            }

            return new string(chars);
        }
    }
}

/*
345. Reverse Vowels of a String

Given a string s, reverse only all the vowels in the string and return it.

The vowels are 'a', 'e', 'i', 'o', and 'u', and they can appear in both lower and upper cases, more than once.

 

Example 1:

Input: s = "IceCreAm"

Output: "AceCreIm"

Explanation:

The vowels in s are ['I', 'e', 'e', 'A']. On reversing the vowels, s becomes "AceCreIm".

Example 2:

Input: s = "leetcode"

Output: "leotcede"

 

Constraints:

    1 <= s.length <= 3 * 105
    s consist of printable ASCII characters.


*/