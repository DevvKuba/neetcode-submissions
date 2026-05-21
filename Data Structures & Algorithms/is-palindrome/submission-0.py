class Solution:
    def isPalindrome(self, s: str) -> bool:
        new_str = ""
        for c in s:
            if c.isalnum(): # checks if letters a-z numbers 0-9 , no spaces commas etc
                new_str += c.lower()
        if new_str == new_str[::-1]: #checking if it's the same reversed
            return True
        return False