public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        // sorted key : list of indexes
        Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

        for (int i = 0; i < strs.Count(); i++) {
            var key = new string(strs[i].OrderBy(c => c).ToArray());

            if(dict.ContainsKey(key)){
                dict[key].Add(strs[i]);
            }
            else {
                dict[key] = new List<string> {strs[i]};
            }
        }

        List<List<string>> res = new List<List<string>>();

        foreach((var key, var val) in dict){
            res.Add(new List<string> (val));
        }
        return res;
    }
}
