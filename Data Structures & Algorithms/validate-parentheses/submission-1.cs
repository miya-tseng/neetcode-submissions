public class Solution {
    public bool IsValid(string s) {
        var stack = new Stack<char>();

        foreach (char c in s) {
            if (c == '(' || c == '{' || c == '[') {
                stack.Push(c);
            } else if (c == ')') {
                stack.TryPop(out char top);
                if (top != '(') return false;
            } else if (c == ']') {
                stack.TryPop(out char top);
                if (top != '[') return false;
            } else if (c == '}') {
                stack.TryPop(out char top);
                if (top != '{') return false;
            }
        }

        return stack.Count == 0;
    }
}
