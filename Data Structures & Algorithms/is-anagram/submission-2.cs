public class Solution {
    public bool IsAnagram(string s, string t) {
        char[] sChar = s.ToCharArray();
        char[] tChar = t.ToCharArray();
        int tempCounter = 0;
        Array.Sort(sChar);
        Array.Sort(tChar);
    
        if (sChar.Length != tChar.Length) return false;

        for (int i = 0; i < sChar.Length; i++){
            if (sChar[i] == tChar[i]){
                tempCounter++;
            }
        }
        return tempCounter == sChar.Length;
    }
    
}
