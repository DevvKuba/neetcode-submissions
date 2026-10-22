public class Solution {
    public bool IsPalindrome(string s) {
        
        var clean = String.Concat(s.Where(c => char.IsLetterOrDigit(c))).ToLower();

        int l = 0;
        int r = clean.Length - 1;

        while(l < r){
            if(clean[l] != clean[r]){
                return false;
            }
            l++;
            r--;
        }
        return true;
    }
}
