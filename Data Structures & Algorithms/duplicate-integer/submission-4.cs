public class Solution {
    public bool hasDuplicate(int[] nums) {
        var counter = new HashSet<int>(nums.Length);
        
        foreach (int num in nums) {
            if (!counter.Add(num)) {
                return true;
            }
        }

        return false;
    }
}