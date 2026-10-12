public class Solution {
    public bool IsPalindrome(string s) {
        string letters = String.Empty;
        int tempIndex = 0;
        for (int i = 0; i < s.Length; i++){
            
          if (char.IsLetterOrDigit(s[i])){
            letters += (s[i]);
          }
        }

        letters = letters.ToLower();

        for (int k = letters.Length - 1; k >= 0; k--){
            if (letters[k].Equals(letters[tempIndex])){
                tempIndex++;
                continue;
            }else{
                return false;
            }
        }
        return true;

    }
}
