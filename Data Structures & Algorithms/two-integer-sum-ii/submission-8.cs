public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int l = 0;
        int r = numbers.Count() - 1;

        while(l < r){
            var current = numbers[l] + numbers[r];

            if(current < target){
                l++;
            }
            else if(current > target){
                r--;
            }
            else {
                return [l + 1, r + 1];
            }
        }
        return [];
    }
}
