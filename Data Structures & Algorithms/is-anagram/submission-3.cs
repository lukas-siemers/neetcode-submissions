public class Solution {
    public bool IsAnagram(string s, string t) {
        char[] sChar = s.ToCharArray();
        char[] tChar = t.ToCharArray();

        Array.Sort(sChar);
        Array.Sort(tChar);
    
        string l = new string(sChar);
        string k = new string(tChar);

        return l == k;
    }
}
