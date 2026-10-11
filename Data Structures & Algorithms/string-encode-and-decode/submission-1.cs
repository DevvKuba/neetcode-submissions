public class Solution {

    public string Encode(List<string> strs) {
        
        string secret = "";

        foreach(var s in strs){
            secret += s.Length.ToString() + '#' + s;
        }
        return secret;
    }

    public List<string> Decode(string s) {
        List<string> decodedSecrets = [];
        int i = 0;

        while(i < s.Length){
            int hash = s.IndexOf('#', i); // first # or after i 
            int length = int.Parse(s[i..hash]); // get length num

            int start = hash + 1; // string start
            int end = start + length; // string end

            decodedSecrets.Add(s[start..end]); // doesn't include last 

            i = end;
        }
        return decodedSecrets;
   }
}
