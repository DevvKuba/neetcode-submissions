public class Solution {
    public int LongestConsecutive(int[] nums)
        {
            HashSet<int> numsSet = new HashSet<int>(nums);

            int longest = 0;

            foreach(int num in numsSet)
            {
                if(!numsSet.Contains(num - 1))
                {
                    int length = 0;
                    while (numsSet.Contains(num + length))
                    {
                        length++;
                    }
                    longest = Math.Max(longest, length);
                }
            }

            return longest;
        }
}
