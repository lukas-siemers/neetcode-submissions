public class Solution {
    public bool hasDuplicate(int[] nums) {
        int last = nums.Length - 1;

        for (int i = 0; i < nums.Length; i++){
            for (int k= 0; k < nums.Length; k++){
                if (nums[i] == nums[k] & i != k) return true;
            }
        }
        return false;
    }
}