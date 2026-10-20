public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        List<List<int>> res = [];

        nums = nums.OrderBy(n => n).ToArray();

        for (int i = 0; i < nums.Count(); i++) {
            if(i > 0 && nums[i] == nums[i - 1]){
                continue;
            }

            var l = i + 1;
            var r = nums.Count() - 1;

            while(l < r){
                var sum = nums[i] + nums[l] + nums[r];

                if(sum < 0){
                    l++;
                }
                else if(sum > 0){
                    r--;
                }
                else {
                    res.Add([nums[i], nums[l], nums[r]]);
                    l++;
                    // necessary - since we are checking for dups outside the while loop
                    while(nums[l] == nums[l - 1] && l < r){
                        l++;
                    }
                }
            }
        }
        return res;
    }
}
