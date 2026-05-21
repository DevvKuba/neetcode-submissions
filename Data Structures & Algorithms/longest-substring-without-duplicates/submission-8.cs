public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if(s is null || s?.Length == 0)
        {
            return 0;
        }

        int longestLength = 1;

        int l = 0;
        int r = l + 1;

        var stringList = s.ToCharArray();

        HashSet<char> currentCharacters = [];
        currentCharacters.Add(s[l]);

        while (l < stringList.Length && r < stringList.Length)
        {
            if (!currentCharacters.Contains(stringList[r]))
            {
                currentCharacters.Add(stringList[r]);
                r++;
            }
            else
            {
                l++;
                r = l + 1;
                currentCharacters.Clear();
                currentCharacters.Add(s[l]);
            }

            if (currentCharacters.Count > longestLength)
            {
                longestLength = currentCharacters.Count;
            }
        }
        return longestLength;
    }
}
