public class Solution {
    public bool IsPalindrome(string s) {
        char[] validValues = "abcdefghijklmnopqrstuvwxyz1234567890".ToCharArray();
        var cleanString = s.Where(x => validValues.Contains(char.ToLower(x))).ToArray();
        int r = 0, l = cleanString.Length - 1;

        while (r <= l)
        {
            if (cleanString[r].ToString().ToLower() != cleanString[l].ToString().ToLower())
            {
                return false;
            }
            r++;
            l--;
        }
        return true;
    }
}
