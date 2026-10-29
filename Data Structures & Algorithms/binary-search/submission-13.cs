public class Solution {
    public int Search(int[] nums, int target) {
        int l = 0;
        int r = nums.Count() - 1;

        while(l <= r){
            var middleIndex = (l + r) / 2;
            var middleValue = nums[middleIndex];

            if(middleValue < target){
                l = middleIndex + 1;
            }
            else if(middleValue > target){
                r = middleIndex - 1;
            }
            else {
                return middleIndex;
            }
        }
        return -1;

    }
}
