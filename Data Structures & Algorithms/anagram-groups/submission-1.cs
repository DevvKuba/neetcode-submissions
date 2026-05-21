public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs)
{

    List<List<string>> resultsList = new List<List<string>>();
    Dictionary<string, List<string>> anagramsDict = new Dictionary<string, List<string>>();

    foreach (string str in strs)
    {
        var sortedStr = String.Concat(str.OrderBy(c => c));
        if (!anagramsDict.ContainsKey(sortedStr))
        {
            anagramsDict.Add(sortedStr, new List<string> { str });
        }
        else
        {
            anagramsDict[sortedStr].Add(str);
        }
    }

    foreach (var item in anagramsDict.Values)
    {
        resultsList.Add(item);
    }

    return resultsList;
}
}
