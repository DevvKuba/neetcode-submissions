public class Solution {
     public bool IsPalindrome(string s)
    {

    int l = 0;
    int r = s.Length - 1;

    while (l < r)
    {

        // while loops allows us to skip white spaces & not alphanumerical values
        while (l < r && !IsAlphaNum(s[l]))
        {
            l++;
        }

        while ( r > l  && !IsAlphaNum(s[r]))
        {
            r--;
        }
        
        if (char.ToLower(s[l]) != char.ToLower(s[r]))
        {
            return false;
        }

        l++;
        r--;
    }

    return true;

}

public static bool IsAlphaNum(char c)
{
    // returns true if its within this range
    return (c >= 'A' && c <= 'Z' ||
            c >= 'a' && c <= 'z' ||
            c >= '0' && c <= '9');
}
 
}
