public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
        List<List<string>> res = new List<List<string>>();

        for(int i = 0; i < strs.Length; i++)
        {
            var charArray = strs[i].ToCharArray();
            Array.Sort(charArray);
            string sortedString = new string(charArray);

            if (dict.ContainsKey(sortedString))
            {
                dict[sortedString].Add(strs[i]);
            }
            else
            {
                dict[sortedString] = new List<string> { strs[i] };
            }
        }

        foreach(var index in dict.Values)
        {
            res.Add(index);
        }

        return res;
    }
}
