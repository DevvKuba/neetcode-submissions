public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> dict = new Dictionary<int,int>();

        for (int i = 0; i < nums.Length; i++) {
            dict[nums[i]] = i;
        }

        for (int i = 0; i < nums.Length; i++) {
            var diff = target - nums[i];

            // check if value is in dict and index aren't the same
            if(dict.TryGetValue(diff, out var res) && dict[diff] != i){
                return [i, dict[diff]];
            }
        }
        return [];
    }
}
