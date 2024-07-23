using System;
using System.Collections.Generic;

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        // Dictionary to store the number and its index
        Dictionary<int, int> numToIndex = new Dictionary<int, int>();

        // Iterate through the array
        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];

            // Check if the complement exists in the dictionary
            if (numToIndex.TryGetValue(complement, out int index))
            {
                // Found the solution, return indices
                return new int[] { index, i };
            }

            // Store the number and its index in the dictionary
            numToIndex[nums[i]] = i;
        }

        // If no solution is found
        throw new ArgumentException("No two sum solution");
    }
}

// Example usage
class Program
{
    static void Main()
    {
        Solution solution = new Solution();

        int[] nums = { 2, 7, 11, 15 };
        int target = 9;

        try
        {
            int[] result = solution.TwoSum(nums, target);
            Console.WriteLine($"Indices: [{result[0]}, {result[1]}]");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
