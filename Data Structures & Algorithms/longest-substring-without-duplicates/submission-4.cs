public class Solution {
    public int LengthOfLongestSubstring(string s)
    {
    int l = 0, r = l;
    int res = 0;
    HashSet<char> set = new HashSet<char>();

    while (r < s.Length)
    {
        if (set.Contains(s[r]))
        {
            l++;
            r = l - 1;
            set.Clear();
        }
        else
        {
            set.Add(s[r]);
            r++;
            res = Math.Max(res, set.Count);

        }
    }

    return res;
}
}
