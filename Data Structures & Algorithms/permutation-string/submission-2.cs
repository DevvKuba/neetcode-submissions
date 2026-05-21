public class Solution {
    public bool CheckInclusion(string s1, string s2)
{
    Dictionary<char, int> freq = new Dictionary<char, int>();
    Dictionary<char, int> freqCopy = new Dictionary<char, int>();

    foreach (char c in s1)
    {
        if (freq.ContainsKey(c))
        {
            freq[c]++;
            freqCopy[c]++;
        }
        else
        {
            freq[c] = 1;
            freqCopy[c] = 1;
        }

    }


    int l = 0;
    for (int r = 0; r < s2.Length; r++)
    {
        if (freq.ContainsKey(s2[r]))
        {
            freq[s2[r]]--;
            if (freq[s2[r]] == 0 && (r - l + 1) == s1.Length)
            {
                return true;
            }
            while (freq[s2[r]] < 0)
            {
                freq[s2[l]]++;
                l++;
            }
        }
        else // character is not in s1 freq dict
        {
            freq = new Dictionary<char, int>(freqCopy);
            l = r + 1;
        }
    }

    return false;
}
}
