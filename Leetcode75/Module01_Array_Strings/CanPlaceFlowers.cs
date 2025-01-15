// see end of the file for problem description

namespace CanPlaceFlowers
{

    public class CanPlaceFlowersSolution
    {
        // STATS:
        // Runtime Complexity: O(N)
        // Runtime beats 99.74% of submissions (checked 15 Jan 2025)
        // Memory Complexity: O(1)
        // Memory beats 81.21% of submissions (checked 15 Jan 2025)
        public bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            int canPlace = 0;

            for (int i = 0; i < flowerbed.Length; i++)
            {
                // Special case: single plot
                if (flowerbed.Length == 1)
                {
                    return flowerbed[0] == 0 ? n <= 1 : n == 0;
                }

                if (i == 0)
                {
                    // First plot: check only the next plot
                    if (flowerbed[i] == 0 && flowerbed[i + 1] == 0)
                    {
                        flowerbed[i] = 1; // Place flower
                        canPlace++;
                    }
                }
                else if (i == flowerbed.Length - 1)
                {
                    // Last plot: check only the previous plot
                    if (flowerbed[i] == 0 && flowerbed[i - 1] == 0)
                    {
                        flowerbed[i] = 1; // Place flower
                        canPlace++;
                    }
                }
                else
                {
                    // Middle plots: check both neighbors
                    if (flowerbed[i] == 0 && flowerbed[i - 1] == 0 && flowerbed[i + 1] == 0)
                    {
                        flowerbed[i] = 1; // Place flower
                        canPlace++;
                    }
                }

                // Early return if we've already placed enough flowers
                if (canPlace >= n)
                {
                    return true;
                }
            }

            return canPlace >= n;
        }
    }

}

/*
605. Can Place Flowers

You have a long flowerbed in which some of the plots are planted, and some are not. However, flowers cannot be planted in adjacent plots.

Given an integer array flowerbed containing 0's and 1's, where 0 means empty and 1 means not empty, and an integer n, return true if n new flowers can be planted in the flowerbed without violating the no-adjacent-flowers rule and false otherwise.

 

Example 1:

Input: flowerbed = [1,0,0,0,1], n = 1
Output: true

Example 2:

Input: flowerbed = [1,0,0,0,1], n = 2
Output: false

 

Constraints:

    1 <= flowerbed.length <= 2 * 104
    flowerbed[i] is 0 or 1.
    There are no two adjacent flowers in flowerbed.
    0 <= n <= flowerbed.length


*/