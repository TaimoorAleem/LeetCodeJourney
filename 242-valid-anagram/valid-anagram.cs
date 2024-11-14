public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char, int> d = new Dictionary<char, int>();

        if (s.Length != t.Length) return false;

        foreach(char c in s) {
            if(d.ContainsKey(c)){
                d[c]++;
            } else {
                d[c] = 1;
            }
        }

        foreach(char c in t) {
            if(d.ContainsKey(c)){
                d[c]--;
                if (d[c] < 0) return false;
            } else return false;
        }

        return true;
    }
}