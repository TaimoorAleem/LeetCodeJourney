public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> d = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++) {
            int diff = target - nums[i];

            if (d.ContainsKey(diff)) {
                return new int[] {i, d[diff]};
            } else {
                d[nums[i]] = i;
            }
        }

        return new int[] {};
    }
}