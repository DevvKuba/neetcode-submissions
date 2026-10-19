public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> set = new HashSet<int>();

        foreach(var val in nums){
            if(set.Contains(val)){
                return true;
            }
            set.Add(val);
        }
        return false;
    }
}