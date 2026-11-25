public class Solution {
    public bool hasDuplicate(int[] nums) {
        var counter = new Dictionary<int,int>();
        
        foreach (int num in nums) {
            if (counter.ContainsKey(num)) {
                return true;
            } else {
                counter.Add(num, 1);
            }
        }

        return false;
    }
}