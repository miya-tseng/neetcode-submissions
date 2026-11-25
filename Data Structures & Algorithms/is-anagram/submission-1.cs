public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;

        var count = new Dictionary<char, int>();

        foreach (char c in s) {
            count[c] = count.GetValueOrDefault(c, 0) + 1;
        }

        foreach (char c in t) {
            if (!count.ContainsKey(c) || count[c] == 0) {
                return false;
            }
            count[c] --;
        }

        return true;
    }
}
