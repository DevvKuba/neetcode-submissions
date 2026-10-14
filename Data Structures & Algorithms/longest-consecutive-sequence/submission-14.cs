public class Solution {
    public int LongestConsecutive(int[] nums) {
        // number is not in the sequence when num - 1 is NOT part of the set
        // that's when we can execute 
        if(nums.Length == 0) return 0;

        var longest = 0;
        HashSet<int> numSet = new HashSet<int>(nums);

        foreach (int num in numSet) {
            if (!numSet.Contains(num - 1)) {
                int length = 1;
                while (numSet.Contains(num + length)) {
                    length++;
                }
                longest = Math.Max(longest, length);
            }
        }
        return longest;
    }
}
