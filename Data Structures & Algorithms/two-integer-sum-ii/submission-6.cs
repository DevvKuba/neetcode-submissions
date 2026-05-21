public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int[] results = new int[2];
        int l = 0;
        int r = numbers.Length - 1;

        while(l <= r)
        {
            int currentTarget = numbers[l] + numbers[r];
            if(currentTarget < target)
            {
                l++;
            }
            else if(currentTarget > target)
            {
                r--;
            }
            else
            {
                results[0] = l + 1;
                results[1] = r + 1;
                return results;
            }
        }
        return results;
            }
}
