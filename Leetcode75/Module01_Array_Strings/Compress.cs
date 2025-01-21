// see the end of file for the problem description

namespace Compress
{
    public class CompressSolution
    {
        // STATS:
        // Runtime Complexity: O(N)
        // Runtime beats 100% of submissions (checked 21 Jan 2025)
        // Memory Complexity: O(1)
        // Memory beats 33.20% of submissions (checked 21 Jan 2025)
        public int Compress(char[] chars)
        {
            // Initialize variables to track the current character and the count of the current character.
            char currentChar = chars[0];
            int count = 1;

            // Initialize the index to write the compressed characters.
            int writeIndex = 0;

            // Iterate through the characters.
            for (int i = 1; i < chars.Length; i++)
            {
                // If the current character is the same as the previous character, increment the count.
                if (chars[i] == currentChar)
                {
                    count++;
                }
                else
                {
                    // Write the current character.
                    chars[writeIndex++] = currentChar;

                    // If the count is greater than 1, write the count.
                    if (count > 1)
                    {
                        foreach (char c in count.ToString())
                        {
                            chars[writeIndex++] = c;
                        }
                    }

                    // Update the current character and reset the count.
                    currentChar = chars[i];
                    count = 1;
                }
            }

            // Write the last character.
            chars[writeIndex++] = currentChar;

            // If the count is greater than 1, write the count.
            if (count > 1)
            {
                foreach (char c in count.ToString())
                {
                    chars[writeIndex++] = c;
                }
            }

            // Return the length of the compressed array.
            return writeIndex;
        }
    }
}