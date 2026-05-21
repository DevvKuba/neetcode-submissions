public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> set = new HashSet<int>(nums);

        if(set.Count == nums.Count())
        {
            return false;
        }
        return true;
    }
}
