public class Solution {
    public bool IsValid(string s) {
        var stack = new Stack<char>();

        foreach (char c in s) {
            if (c == '(' || c == '{' || c == '[') {
                stack.Push(c);
            } else if (c == ')') {
                if (!stack.TryPop(out char top) || top != '(') return false;
            } else if (c == ']') {
                if (!stack.TryPop(out char top) || top != '[') return false;
            } else if (c == '}') {
                if (!stack.TryPop(out char top) || top != '{') return false;
            }
        }

        return stack.Count == 0;
    }
}
