public class Solution
{
    public bool hasDuplicate(int[] nums)
    {
        Dictionary<int,int> list = new Dictionary<int,int>();
        foreach(var num in nums){
            if (list.ContainsKey(num)){
                return true;
            }else{
                list.Add(num,1);
            }
        }
        return false;
    }
}