public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var dic = new Dictionary<int,int>();
        for (int i=0; i<nums.Length; i++) {
            int need = target - nums[i];
            if (dic.ContainsKey(need)) {
                return [dic[need], i];
            }
            dic.Add(nums[i],i);
        }
        return new int[2];
    }
}
