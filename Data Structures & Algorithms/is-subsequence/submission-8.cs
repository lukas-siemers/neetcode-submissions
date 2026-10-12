public class Solution {
    public bool IsSubsequence(string s, string t) {
        char[] sA = s.ToCharArray();
        char[] sT = t.ToCharArray();

        int i = 0;
        foreach(var letter in sT){
            if (i < sA.Length && sA[i] == letter) i++;
        }
        return i == sA.Length;
    }
}