// see end of the file for problem description

namespace IncreasingTriplet
{
    public class IncreasingTripletSolution
    {

        // STATS:
        // Runtime Complexity: O(N)
        // Runtime beats 93.42% of submissions (checked 16 Jan 2025)
        // Memory Complexity: O(1)
        // Memory beats 46.78% of submissions (checked 16 Jan 2025)
        public bool IncreasingTriplet(int[] nums)
        {
            // According to constraints, the array has to be at least size 1.
            // If the size is 1 or 2, it cannot include triplets. 
            if (nums.Length < 3)
            {
                return false;
            }

            // Initialize variables to track the smallest and second smallest numbers.
            int first = int.MaxValue;
            int second = int.MaxValue;

            foreach (int num in nums)
            {
                if (num <= first)
                {
                    // Update first if the current number is smaller.
                    first = num;
                }
                else if (num <= second)
                {
                    // Update second if the current number is larger than first but smaller than second.
                    second = num;
                }
                else
                {
                    // If the current number is greater than both first and second, return true.
                    return true;
                }
            }

            // If no triplet is found, return false.
            return false;
        }
    }
}


/*
334. Increasing Triplet Subsequence

Given an integer array nums, return true if there exists a triple of indices (i, j, k) such that i < j < k and nums[i] < nums[j] < nums[k]. If no such indices exists, return false.

 

Example 1:

Input: nums = [1,2,3,4,5]
Output: true
Explanation: Any triplet where i < j < k is valid.

Example 2:

Input: nums = [5,4,3,2,1]
Output: false
Explanation: No triplet exists.

Example 3:

Input: nums = [2,1,5,0,4,6]
Output: true
Explanation: The triplet (3, 4, 5) is valid because nums[3] == 0 < nums[4] == 4 < nums[5] == 6.

 

Constraints:

    1 <= nums.length <= 5 * 105
    -231 <= nums[i] <= 231 - 1

 
Follow up: Could you implement a solution that runs in O(n) time complexity and O(1) space complexity?
*/