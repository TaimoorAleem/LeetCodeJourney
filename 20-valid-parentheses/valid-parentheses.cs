public class Solution {
    public bool IsValid(string s) {
        Stack<char> s1 = new Stack<char>();

        foreach(char c in s) {
            if (c == '(' || c == '{' || c == '[') {
                s1.Push(c);
            } else {
                if (s1.Count == 0) return false;

                char p = s1.Pop();

                if ((c == ')' && p != '(') || (c == '}' && p != '{') || (c == ']' && p != '[')) {
                    return false;
                }
            }
        }

        return s1.Count == 0;
    }
}