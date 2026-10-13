public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        //Initial brute force would be a nested loop
        //Better solution would be a dictionary that would store the results ?
        //We could also do a two points where we increase the start once the end reach the start
        Dictionary<int, int> result = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (result.ContainsKey(nums[i]))
            {
                return new int[] { result[nums[i]], i };
            }
            result[target - nums[i]] = i;
        }
        return Array.Empty<int>();
    }
}
