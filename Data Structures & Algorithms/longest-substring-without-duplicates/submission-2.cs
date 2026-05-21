public class Solution {
    public int LengthOfLongestSubstring(string s)
{
    int l = 0;
    int r = l;
    int result = 0;
    HashSet<string> set = new HashSet<string>();

    while (r < s.Length)
    {
        if (set.Contains(s[r].ToString()))
        {
            l++;
            r = l;
            set.Clear();
        }
        else
        {
            set.Add(s[r].ToString());
            result = Math.Max(result, set.Count);
            r++;
        }

    }
    return result;

}
}
