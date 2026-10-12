public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] result = new int[2];
        for(int i = 0; i < nums.Length; i++){
            for (int k = 0; k < nums.Length; k++){
                if (nums[i] + nums[k] == target && i != k){
                    if (i < k){
                    result[0] = i;
                    result[1] = k;
                    }else{
                    result[0] = k;
                    result[1] = i; 
                    }
                }
            }
        }
        return result;
    }
}
