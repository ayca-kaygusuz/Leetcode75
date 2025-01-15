// see end of the file for problem description

namespace ProductExceptSelf
{
    public static class ProductExceptSelfSolution
    {
        public static int[] ProductExceptSelf(int[] nums)
        {
            int productOfAll = 1;
            int productOfAllOthers = 1; // this is kept for cases where there is a single 0 element

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    /*  
                        if the current element is zero, product of everything will be zero. 
                        we keep a seperate variable for every element except the current element 
                        so that if there is a single zero, we don't lose the product of
                        all other elements. if there are more than one zero,
                        this is moot, but still beats the complexity of
                        checking how many zeroes there are.
                    */
                    productOfAllOthers = productOfAll;
                    productOfAll = 0;
                }
                else
                {
                    productOfAll *= nums[i];
                }
            }

            int[] productExceptSelf = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    /*
                        in all cases except nums[i]==0, the product of all other elements
                        is simply the product of all elements divided by the current
                        element. This reduces complexity and avoids overiteration.
                    */
                    productExceptSelf[i] = productOfAll / nums[i];
                }
                else
                {
                    /*
                        if the current element is zero, we would have a division by zero error.
                        This is why we keep a "product of all others" variable that takes effect
                        if an element is zero, pertaining product of all other elements except for the
                        current zero.
                    */
                    productExceptSelf[i] = productOfAllOthers;
                }

            }

            return productExceptSelf;
        }
    }
}


/*
238. Product of Array Except Self
Solved
Medium
Topics
Companies
Hint

Given an integer array nums, return an array answer such that answer[i] is equal to the product of all the elements of nums except nums[i].

The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.

You must write an algorithm that runs in O(n) time and without using the division operation.

 

Example 1:

Input: nums = [1,2,3,4]
Output: [24,12,8,6]

Example 2:

Input: nums = [-1,1,0,-3,3]
Output: [0,0,9,0,0]

 

Constraints:

    2 <= nums.length <= 105
    -30 <= nums[i] <= 30
    The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.

 

Follow up: Can you solve the problem in O(1) extra space complexity? (The output array does not count as extra space for space complexity analysis.)

*/