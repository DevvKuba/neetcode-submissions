public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int n = nums.Count();
        int[] prefix = new int[n]; 
        int[] suffix = new int[n]; 
        int[] res = new int[n]; // each res -> beforeVal * afterVal (after computations)

        for (int i = 0; i < n; i++) {
            if(i == 0){
                prefix[i] = nums[i];
            }
            else{
                prefix[i] = nums[i] * prefix[i - 1];
            }
        }

        for (int i = n - 1; i >= 0; i--) {
            if(i == n - 1){
                suffix[i] = nums[i];
            }
            else{
                suffix[i] = nums[i] * suffix[i + 1];
            }
        }

        for (int i = 0; i < n; i++) {
            var pVal = i > 0 ? prefix[i - 1] : 1;

            var sVal = i < n - 1 ? suffix[i + 1] : 1;

            res[i] = pVal * sVal;
        }

        return res;
    }
}

