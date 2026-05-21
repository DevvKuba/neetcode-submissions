public class Solution {
    public int CharacterReplacement(string s, int k)
{
    Dictionary<char, int> chars = new Dictionary<char, int>();
    int l = 0, maxf = 0;
    int res = 0;

    for (int r = 0; r < s.Length; r++)
    {
        if (!chars.ContainsKey(s[r]))
        {
            chars[s[r]] = 1;
        }
        else if (chars.ContainsKey(s[r]))
        {
            chars[s[r]]++;

        }

        maxf = Math.Max(maxf, chars[s[r]]);

        while ((r - l + 1) - maxf > k)
        {
            chars[s[l]]--;
            l++;
        }

        res = Math.Max(res, r - l + 1);


    }

    return res;


}
}
