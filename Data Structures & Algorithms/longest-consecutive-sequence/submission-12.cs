public class Solution {
    public int LongestConsecutive(int[] nums) {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        int counter = 0;
        if(nums.Length == 0)
        {
            return counter;
        }

        int minNum = nums.Min();

        for (int i = 0; i < nums.Length; i++)
        {
            dict.Add(i, nums[i]);

        }

        foreach (int i in dict.Keys)
        {
            int currentValue = dict[i];
            int loopCounter = 1;

            while (dict.ContainsValue(currentValue - 1) & currentValue > minNum)
            {
                loopCounter++;
                currentValue--;
            }

            // check if need to increase counter
            if (loopCounter > counter)
            {
                counter = loopCounter;
            }

        }

        return counter;
    }
}
