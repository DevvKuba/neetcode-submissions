public class Solution {
    public int LongestConsecutive(int[] nums) {
        var longest = 0;

        var numSet = nums.ToHashSet();

        foreach(var num in nums){
            // we want to search if num - 1 is NOT in set
            if(!numSet.Contains(num - 1)){
                var length = 1;
                var curr = num;

                while(numSet.Contains(curr + 1)){
                    length++;
                    curr++;
                }
                longest = Math.Max(longest, length);
                length = 1;
            }
        }
        return longest;
    }
}
