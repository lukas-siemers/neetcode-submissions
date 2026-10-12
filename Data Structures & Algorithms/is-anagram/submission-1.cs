public class Solution {
    public bool IsAnagram(string s, string t) {
        char[] forw = s.ToCharArray();
        char[] back = t.ToCharArray();
        //To a character Array
        //Gives acces to single characters
        Array.Sort(forw);
        Array.Sort(back);

        if (forw.Length != back.Length) return false;

        int counter = 0;
        //Sorting the arrays so the letters are in the same order
        for (int i = 0; i < forw.Length; i++){
            for (int k = 0; k < back.Length; k++){
                if (forw[i] == back[k] && i == k){
                    counter++;
                    Console.WriteLine(forw[i] + " - " + back[k]);
                    continue;
                }
            }
        }
        return counter == forw.Length;
    }
}
