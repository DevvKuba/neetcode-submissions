public class Solution {
    public int FindDuplicate(int[] nums) {
        Dictionary<int, int> values = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++){
            if(values.ContainsValue(nums[i])){
                return nums[i];
            }
            else {
                values[i] = nums[i];
            }
        }

        return 0;
    }
}
