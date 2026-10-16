public class Solution {
    public bool IsPalindrome(string s) {
        // I need to ensure cases are ignored
        // and that we don't account for non-alphanumeric numbers

        var clean = string.Concat(s.Where(c => char.IsLetterOrDigit(c))).ToLower();
        // var trimmed = clean.Trim();

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
