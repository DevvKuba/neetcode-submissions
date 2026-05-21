public class Solution {
    public int LengthOfLongestSubstring(string s)
{
    HashSet<char> chars = new HashSet<char>();
    int l = 0;
    int res = 0;

    for (int r = 0; r < s.Length; r++)
    {
        if (chars.Contains(s[r]))
        {
            l++;
            r = l - 1;
            chars.Clear();
        }
        else
        {
            chars.Add(s[r]);
            res = Math.Max(res, chars.Count);
        }
    }

    return res;
}
   
}
