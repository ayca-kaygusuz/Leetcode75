// see end of the file for problem description

namespace LargestAltitude
{
    public class LargestAltitudeSolution
    {
        // STATS:
        // Runtime Complexity: O(N)
        // Runtime beats 10.73% of submissions (checked 15 Jan 2025)
        // Memory Complexity: O(N)
        // Memory beats 37.20% of submissions (checked 15 Jan 2025)
        public int LargestAltitude(int[] gain)
        {
            // Create an array to store cumulative altitudes
            int[] altitudes = new int[gain.Length + 1];  // Array of size n + 1 to store altitude at each step
            altitudes[0] = 0;  // Start at altitude 0

            // Calculate the cumulative altitude after each step
            for (int i = 0; i < gain.Length; i++)
            {
                // The altitude at the next step is the previous altitude + the gain at that step
                altitudes[i + 1] = altitudes[i] + gain[i];
            }

            // Return the maximum altitude from the altitudes array
            return altitudes.Max();
        }
    }
}

/*
1732. Find the Highest Altitude

There is a biker going on a road trip. The road trip consists of n + 1 points at different altitudes. The biker starts his trip on point 0 with altitude equal 0.

You are given an integer array gain of length n where gain[i] is the net gain in altitude between points i​​​​​​ and i + 1 for all (0 <= i < n). Return the highest altitude of a point.

 

Example 1:

Input: gain = [-5,1,5,0,-7]
Output: 1
Explanation: The altitudes are [0,-5,-4,1,1,-6]. The highest is 1.

Example 2:

Input: gain = [-4,-3,-2,-1,4,3,2]
Output: 0
Explanation: The altitudes are [0,-4,-7,-9,-10,-6,-3,-1]. The highest is 0.

 

Constraints:

    n == gain.length
    1 <= n <= 100
    -100 <= gain[i] <= 100


*/