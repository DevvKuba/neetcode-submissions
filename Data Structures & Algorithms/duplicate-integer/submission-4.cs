public class Solution {
    public bool hasDuplicate(int[] nums) {

        Dictionary<int, int> numsDict = new Dictionary<int, int>();

        foreach (int num in nums)
        {
            if (numsDict.ContainsKey(num))
            {
                return true;
            }
            else
            {
                numsDict.Add(num, 1);
            }
        }
        return false;

    }
}
