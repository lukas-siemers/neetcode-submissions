public class Solution {
    public bool IsAnagram(string s, string t) {
        char[] sc = s.ToCharArray();
        char[] tc = t.ToCharArray();

        Array.Sort(sc);
        Array.Sort(tc);
        Console.WriteLine("SC: " + sc.ToString() + " S " + tc.ToString());
        return sc.SequenceEqual(tc);


        }
}
