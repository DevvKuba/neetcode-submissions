public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        List<List<int>> res = [];

        nums = nums.OrderBy(n => n).ToArray();

        for (int i = 0; i < nums.Count(); i++) {
            if(i > 0 && nums[i - 1] == nums[i]){
                continue;
            }

            int l = i + 1;
            int r = nums.Count() - 1;

            while(l < r){
                int current = nums[i] + nums[l] + nums[r];

                if(current > 0){
                    r--;
                }
                else if(current < 0){
                    l++;
                }
                else {
                    res.Add([nums[i], nums[l], nums[r]]);
                    l++;

                    while(nums[l - 1] == nums[l] && l < r){
                        l++;
                    }
                }
            }
        }

        return res;
    }
}
