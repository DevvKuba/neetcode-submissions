public class Solution {
    public int LongestConsecutive(int[] nums) {
        
        if(nums.Length == 0) return 0;

        var longest = 0;

        HashSet<int> set = new HashSet<int>(nums);

        foreach(var num in set){
            var length = 0;

            if(!set.Contains(num - 1)){
                while(set.Contains(num + length)){
                    length++;
                    longest = Math.Max(longest, length);
                }
            }
        }
        return longest;
    }
}
