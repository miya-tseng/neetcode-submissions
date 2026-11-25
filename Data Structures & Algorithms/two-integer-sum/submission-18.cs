public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var dic = new Dictionary<int,int>();
        for (int i=0; i<nums.Length; i++) {
            int need = target - nums[i];
            if (dic.TryGetValue(need, out int index)) {
                return [index, i];
            }
            dic[nums[i]] = i;
        }
        return [];
    }
}
