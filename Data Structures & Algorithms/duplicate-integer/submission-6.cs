public class Solution
{
    public bool hasDuplicate(int[] nums)
    {
        Dictionary<int, int> result = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++){
            if(result.ContainsKey(nums[i])) return true;
            else
            {
                result[nums[i]] = i;
            }
        }

        return false;
    }
}