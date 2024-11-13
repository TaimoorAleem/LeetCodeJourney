public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> uniqueNums = new HashSet<int>();

        foreach(int n in nums) {
            if(uniqueNums.Contains(n)) {
                return true;
            } else {
                uniqueNums.Add(n);
            }
        }

        return false;
    }
}