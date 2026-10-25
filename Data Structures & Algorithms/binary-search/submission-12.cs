public class Solution {
    public int Search(int[] nums, int target) {
        int l = 0;
        int r = nums.Length - 1;

        while(l <= r){
            var midIndex = (l + r) / 2;
            var midVal = nums[midIndex];

            if(midVal > target){
                r--;
            }
            else if(midVal < target){
                l++;
            }
            else {
                return midIndex;
            }
        }
        return - 1;
    }
}
