public class Solution {
    public int CharacterReplacement(string s, int k) {
        if (s.Length == 0 || s is null) return 0;

        // letter : count
        var count = new Dictionary<char, int>();
        int res = 0;

        int l = 0, maxf = 0, windowLength = 0;

        for(int r = 0; r < s.Length; r++)
        {
            if (count.ContainsKey(s[r]))
            {
                count[s[r]]++;
            }
            else
            {
                count[s[r]] = 1;
            }

            maxf = Math.Max(maxf, count[s[r]]);
            windowLength = r - l + 1;

            // while window is not valid -- cannot make more than k replacements , need to shift
            while((windowLength - maxf) > k)
            {
                count[s[l]]--;
                l++;
                windowLength = r - l + 1;
            }

            res = Math.Max(res, windowLength);
        }
        return res;
    }
}
