public class Solution {
    public int LongestConsecutive(int[] nums) {
        // number is not in the sequence when num - 1 is NOT part of the set
        // that's when we can run 
        if(nums.Length == 0) return 0;

        var longest = 0;

        HashSet<int> set = new HashSet<int>(nums);
        
        foreach(var num in set){
            var length = 0;

            if(!set.Contains(num - 1)){ // potential start of sequence
                while(set.Contains(num + length)){
                    length++;
                    longest = Math.Max(longest, length);
                }
            }
        }
        return longest;
    }
}
