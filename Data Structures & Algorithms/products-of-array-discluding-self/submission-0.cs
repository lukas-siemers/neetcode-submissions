public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] result = new int[nums.Length];  //Creating a new array with the Length of the other Array
        int rightProduct = 1; // Starting at 1
        int leftProduct = 1;    // Starting at 1


        for (int i = 0; i < nums.Length; i++)
        {
            //Loopin thru our arrat forward
            result[i] = leftProduct;
            leftProduct *= nums[i];
        }

        for (int i = nums.Length - 1; i >= 0; i--)
        {
            //Looping thru the array backwards
            result[i] *= rightProduct;
            rightProduct *= nums[i];
        }

        return result;
        }
}
