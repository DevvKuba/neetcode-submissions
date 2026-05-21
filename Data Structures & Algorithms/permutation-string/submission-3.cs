public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        var dict = new Dictionary<char, int>();

        foreach(char c in s1)
        {
            if (dict.ContainsKey(c))
            {
                dict[c]++;
            }
            else
            {
                dict[c] = 1;
            }
        }

        var originalDict = new Dictionary<char, int>(dict);

        int l = 0, r = 0, windowLength = 0;

        while(l < s2.Length && r < s2.Length)
        {
            if (dict.ContainsKey(s2[r]) && dict[s2[r]] > 0)
            {
                dict[s2[r]]--;
                // start extending window
                windowLength = r - l + 1;
                if (windowLength == originalDict.Values.Sum())
                {
                    return true;
                }
                r++;
            }
            else
            {
                dict = new Dictionary<char, int>(originalDict);
                l++;
                r = l;
            }
            
        }
        return false;
    }
}
