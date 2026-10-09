public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        // sorted key : List<int> of indices
        Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

        for (int i = 0; i < strs.Length; i++) {
            var key = new string(strs[i].OrderBy(c => c).ToArray());

            if(dict.TryGetValue(key, out var val)){
                dict[key].Add(strs[i]);
            }
            else {
                dict[key] = new List<string> {strs[i]};
            }
        }

        List<List<string>> res = new List<List<string>>();

        foreach((var key, var valueList) in dict){
            res.Add(valueList);
        }
        return res;
    }
}
