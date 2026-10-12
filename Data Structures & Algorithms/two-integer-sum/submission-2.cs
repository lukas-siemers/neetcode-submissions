public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int left = 0;
        int right = nums.Length;
        for (int i = 0; i < nums.Length; i++){
            for (int d = 0; d < nums.Length; d++){
                if (nums[i] + nums[d] == target && i != d){
                    return [i,d];
                }
            
        }   
        }
        return [0,0];
    }
}
