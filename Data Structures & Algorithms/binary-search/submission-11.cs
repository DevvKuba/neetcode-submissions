public class Solution {
    public int Search(int[] nums, int target) {
        if(nums.Count() == 0) return -1;

        var l = 0;
        var r = nums.Count() - 1;

        while(l <= r){
            var middleIndex = (l + r) / 2;
            var middleVal = nums[middleIndex];

            if(middleVal > target){
                r = middleIndex - 1;
            }
            else if(middleVal < target){
                l = middleIndex + 1;
            }
            else {
                return middleIndex;
            }
        }
        return -1;
    }
}
