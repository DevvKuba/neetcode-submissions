public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int l = 0, r = numbers.Length - 1;
        int[] arr = new int[2];
        while (l <= r)
        {
            int res = numbers[l] + numbers[r];
            if (res > target)
            {
                r--;
            }
            else if (res < target)
            {
                l++;
            }
            else
            {
                arr[0] = l + 1;
                arr[1] = r + 1;
                return arr;

            }
        }
        return arr;
    }
}
