public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<int,int> dictOne = new Dictionary<int,int>();
        Dictionary<int,int> dictTwo = new Dictionary<int,int>();

        if(s.Length != t.Length) return false;

        foreach(char c in s){
            if(dictOne.ContainsKey(c)){
                dictOne[c]++;
            }
            else {
                dictOne[c] = 1;
            }
        }

        foreach(char c in t){
             if(dictTwo.ContainsKey(c)){
                dictTwo[c]++;
            }
            else {
                dictTwo[c] = 1;
            }
        }

        foreach((var key, var val) in dictOne){
            if(dictOne.ContainsKey(key) && dictTwo.ContainsKey(key)){
                if(val != dictTwo[key]){
                    return false;
                }
            }
            else {
                return false;
            }
        }
        return true;


    }
}
