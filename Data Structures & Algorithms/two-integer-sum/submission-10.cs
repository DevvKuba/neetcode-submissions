public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        int[] res = new int[2];

        for (int i = 0; i < nums.Length; i++)
        {
            if (dict.ContainsKey(nums[i]))
            {
                // check for target else just treat it as a singular value
                if (nums[i] * 2 == target)
                {
                    res[0] = dict[nums[i]];
                    res[1] = i;
                    return res;
                }
            }
            dict.Add(nums[i], i);
        }


        for (int i = 0; i < nums.Length; i++)
        {
            int lfn = target - nums[i];
            if (dict.ContainsKey(lfn) && lfn != nums[i])
            {
                res[0] = i;
                res[1] = dict[lfn];
                return res;
            }
        }
        return res;
    }
}
