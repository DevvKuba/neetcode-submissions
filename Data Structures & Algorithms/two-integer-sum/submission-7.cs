public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        //List<int> indexes = new List<int>();
        Dictionary<int, int> numsDict = new Dictionary<int, int>();
        int targetNum;

        for (int i = 0; i < nums.Length; i++)
        {
            targetNum = target - nums[i];
            if (numsDict.ContainsKey(targetNum))
            {
                return new int[] { numsDict[targetNum], i };
                //indexes.Add(numsDict[targetNum]);
                //indexes.Add(i);
            }
            else
            {
                numsDict[nums[i]] = i;
            }
        }
        return null;

    }
}
