public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int l = 0;
        int r = numbers.Length - 1;

        while(l < r){
            var currentTarget = numbers[l] + numbers[r];

            if(currentTarget < target){
                l++;
            }
            else if(currentTarget > target){
                r--;
            }
            else {
                l++;
                r++;
                return [ l, r ];
            }
        }
        return [];
    }
}
