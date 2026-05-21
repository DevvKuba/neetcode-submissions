public class Solution {
    public int[] TwoSum(int[] numbers, int target)
{
    int[] res = new int[2];

    int l = 0;
    int r = numbers.Length - 1;

    while (l < r)
    {
        int currentRes = numbers[l] + numbers[r];
        if (currentRes == target)
        {
            res[0] = l + 1;
            res[1] = r + 1;
            return res;
        }
        else if (currentRes < target)
        {
            l++;
        }
        else if(currentRes > target)
        {
            r--;
        }
    }

    return res;

}
}
