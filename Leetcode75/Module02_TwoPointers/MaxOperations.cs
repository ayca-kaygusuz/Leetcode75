// see the end of the file for problem description

namespace MaxOperations
{
    public class MaxOperationsSolution
    {
        // STATS:
        // Runtime Complexity: O(NlogN)
        // Runtime beats 54.89% of submissions (checked 21 Jan 2025)
        // Memory Complexity: O(1)
        // Memory beats 82.72% of submissions (checked 21 Jan 2025)
        public int MaxOperations(int[] nums, int k)
        {
            // Sort the array to use the two-pointer technique
            Array.Sort(nums);

            int left = 0; // Initialize the left pointer
            int right = nums.Length - 1; // Initialize the right pointer
            int count = 0; // Initialize the count of operations

            // Iterate while the left pointer is less than the right pointer
            while (left < right)
            {
                int sum = nums[left] + nums[right]; // Calculate the sum of the elements at the pointers

                if (sum == k)
                {
                    // If the sum is equal to k, increment the count and move both pointers inward
                    count++;
                    left++;
                    right--;
                }
                else if (sum < k)
                {
                    // If the sum is less than k, move the left pointer to the right to increase the sum
                    left++;
                }
                else
                {
                    // If the sum is greater than k, move the right pointer to the left to decrease the sum
                    right--;
                }
            }

            // Return the total count of operations
            return count;
        }
    }
}

/*

1679. Max Number of K-Sum Pairs

You are given an integer array nums and an integer k.

In one operation, you can pick two numbers from the array whose sum equals k and remove them from the array.

Return the maximum number of operations you can perform on the array.

 

Example 1:

Input: nums = [1,2,3,4], k = 5
Output: 2
Explanation: Starting with nums = [1,2,3,4]:
- Remove numbers 1 and 4, then nums = [2,3]
- Remove numbers 2 and 3, then nums = []
There are no more pairs that sum up to 5, hence a total of 2 operations.

Example 2:

Input: nums = [3,1,3,4,3], k = 6
Output: 1
Explanation: Starting with nums = [3,1,3,4,3]:
- Remove the first two 3's, then nums = [1,4,3]
There are no more pairs that sum up to 6, hence a total of 1 operation.

*/