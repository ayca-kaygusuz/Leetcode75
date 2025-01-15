// see end of the file for problem description

namespace GcdOfStrings
{

    public class GcdOfStringsSolution
    {
        // STATS:
        // Runtime Complexity: O(N+Log(Min(N,M)))
        // Runtime beats 100% of submissions (checked 15 Jan 2025)
        // Memory Complexity: O(Log(Min(N,M)))
        // Memory beats 62.01% of submissions (checked 15 Jan 2025)

        public string GcdOfStrings(string str1, string str2)
        {
            // If concatenating str1 + str2 is not equal to str2 + str1, there is no common divisor
            if ((str1 + str2) != (str2 + str1))
                return "";

            // Use the GCD of the lengths of the strings to find the largest common divisor string
            int gcdLength = Gcd(str1.Length, str2.Length);
            return str1.Substring(0, gcdLength);
        }

        private int Gcd(int a, int b)
        {
            return b == 0 ? a : Gcd(b, a % b);
        }

    }

}

/*
1071. Greatest Common Divisor of Strings

For two strings s and t, we say "t divides s" if and only if s = t + t + t + ... + t + t (i.e., t is concatenated with itself one or more times).

Given two strings str1 and str2, return the largest string x such that x divides both str1 and str2.

 

Example 1:

Input: str1 = "ABCABC", str2 = "ABC"
Output: "ABC"

Example 2:

Input: str1 = "ABABAB", str2 = "ABAB"
Output: "AB"

Example 3:

Input: str1 = "LEET", str2 = "CODE"
Output: ""

 

Constraints:

    1 <= str1.length, str2.length <= 1000
    str1 and str2 consist of English uppercase letters.


*/