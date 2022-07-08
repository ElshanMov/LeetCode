// See https://aka.ms/new-console-template for more information
public class Solution
{
    //Example 1:

    //Input: nums = [2,7,11,15], target = 9
    //Output: [0,1]
    //Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
    public static void Main()
    {
        var result = TwoSum(new int[] { 14, 5, 5, 5, 1 }, 6);
        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
    }

    /// <summary>
    // Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

    //You may assume that each input would have exactly one solution, and you may not use the same element twice.

    //You can return the answer in any order.
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="target"></param>
    /// <returns>integer array of indexes</returns>
    public static int[] TwoSum(int[] nums, int target)
    {
        //Declarations
        var arrayLength = nums.Length;

        //Validations
        if (nums == null || nums.Length < 2)
        {
            return Array.Empty<int>();
        }

        //Logic
        for (int i = 0; i < arrayLength; i++)
        {
            for (int j = i+1; j < arrayLength; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return new int[] { i, j };
                }
            }
        }
        return Array.Empty<int>();
    }

}


