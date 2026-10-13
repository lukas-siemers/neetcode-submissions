public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int> result = new Dictionary<int,int>();//Key which is num and value which is count
        for(int i = 0; i < nums.Length ; i++){
            if (result.ContainsKey(nums[i])){
                result[nums[i]]++;  //Increase count
            }else{
                result[nums[i]] = 1; //Add default value of 1
            }
        }

        var ordered = result.OrderByDescending(entry => entry.Value);
        return ordered
                .Take(k)    //Size of the Take
                .Select(entry => entry.Key) //This is going to be the Key
                .ToArray(); //and the list to return
    }
}
