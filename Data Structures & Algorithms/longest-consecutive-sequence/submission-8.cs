public class Solution {
    public int LongestConsecutive(int[] nums)
    {

    if(nums.Length == 0) return 0;

    Dictionary<int,int> numsDict = new Dictionary<int,int>();

    foreach(int num in nums)
    {
        if (!numsDict.ContainsKey(num))
        {
            numsDict[num] = num;
        }
    }

    // startNum needs to be the smallest value
    int startNum = nums.Min(x => x);
    int largestNum = nums.Max(x => x);
    int currentSequence = 0;
    int longestSequence = 0;

    for(int i = startNum; i <= largestNum; i++)
    {
        if (numsDict.ContainsKey(i))
        {
            currentSequence++;
            if(currentSequence > longestSequence)
            {
                longestSequence = currentSequence;
            }
        }
        if (!numsDict.ContainsKey(i + 1))
        {
            currentSequence = 0;
        }

    }

    return longestSequence;
}
}
