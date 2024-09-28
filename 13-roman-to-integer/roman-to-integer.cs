public class Solution {
    public int RomanToInt(string s) {
        Dictionary<char, int> d = new Dictionary<char, int>() {
            {'I' , 1},
            {'V' , 5},
            {'X' , 10},
            {'L' , 50},
            {'C' , 100},
            {'D' , 500},
            {'M' , 1000},
        };

        int sum = 0;

        for (int i = 0; i < s.Length; i++) {
            if (i < s.Length - 1 && d[s[i]] < d[s[i + 1]]) {
                sum -= d[s[i]];
            } else {
                sum += d[s[i]];
            }
        }

        return sum;
    }
}