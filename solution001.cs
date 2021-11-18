// Two Sum
// Difficulty: Easy

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        for (int i = 0; i < nums.Count(); i++)
        {
            for(int j = i + 1; j < nums.Count(); j++)
            {
                if(nums[i] + nums[j] == target)
                {
                    return new int[2] { i, j };
                }
            }
        }
            
        return null;
    }
}
