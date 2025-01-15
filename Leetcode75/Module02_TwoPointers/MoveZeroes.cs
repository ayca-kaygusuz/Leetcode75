// see end of the file for problem description

namespace MoveZeroes
{
    public class MoveZeroesSolution
    {
        // STATS:
        // Runtime Complexity: O(N)
        // Runtime beats 90.56% of submissions (checked 15 Jan 2025)
        // Memory Complexity: O(1)
        // Memory beats 37.95% of submissions (checked 15 Jan 2025)
        public void MoveZeroes(int[] nums)
        {
            int nonZeroIndex = 0; // Pointer for the next non-zero position

            // Move all non-zero elements to the front
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    // Swap nums[i] and nums[nonZeroIndex]
                    int temp = nums[nonZeroIndex];
                    nums[nonZeroIndex] = nums[i];
                    nums[i] = temp;

                    nonZeroIndex++;
                }
            }
        }
    }

}

/*
283. Move Zeroes

Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.

Note that you must do this in-place without making a copy of the array.

 

Example 1:

Input: nums = [0,1,0,3,12]
Output: [1,3,12,0,0]

Example 2:

Input: nums = [0]
Output: [0]

 

Constraints:

    1 <= nums.length <= 104
    -231 <= nums[i] <= 231 - 1

 
Follow up: Could you minimize the total number of operations done?
*/