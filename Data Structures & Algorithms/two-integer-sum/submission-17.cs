public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,List<int>> dict = new Dictionary<int, List<int>>();

        for(int i = 0; i < nums.Length; i++){
            var key = nums[i];

            if(dict.ContainsKey(key))
            {
                dict[key].Add(i);
            }
            else 
            {
                dict[key] = new List<int> {i};
            }
        }

        for (int i = 0; i < nums.Length; i++) {
            var num = nums[i];
            var newTarget = target - num;

            if(dict.TryGetValue(newTarget, out var res)) 
            {
                if(num != newTarget)
                {
                    return [i, dict[newTarget][0]];
                }

                if(num == newTarget && dict[newTarget].Count > 1)
                {
                    return [dict[newTarget][0], dict[newTarget][1]];
                }
            }
        }
        return [];
    }
}
