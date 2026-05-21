class Solution:
    
    def longestConsecutive(self,nums: List[int]) -> int:
        n_set = set(nums)
        longest_sequence = 0
        for n in nums:
            if (n - 1) not in n_set: # establishes it as start of the sequence
                length = 0
                while (n + length) in n_set: #first value
                    length += 1 #tracks length and represents next v incriment
                if length > longest_sequence:
                    longest_sequence = length
        return longest_sequence




