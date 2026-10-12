public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int[] result = new int[2];

        for(int i=0;i<numbers.Length;i++){
            for(int k=0;k<numbers.Length;k++){
                if (i != k && numbers[i] + numbers[k] == target){
                    if (i < k){
                    result[0] = i+1;
                    result[1] = k+1;
                    }else{
                    result[0] = k+1;
                    result[1] = i+1;
                    }

                }
            }
        }
        return result;
    }
}
