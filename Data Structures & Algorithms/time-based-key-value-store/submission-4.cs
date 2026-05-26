public class TimeMap
{
    public Dictionary<(string, int), string> Dict { get; set; }

    public TimeMap()
    {
        Dict = new Dictionary<(string, int), string>();
    }

    public void Set(string key, string value, int timestamp)
    {
        Dict[(key, timestamp)] = value;
    }

    public string Get(string key, int timestamp)
    {
        string returnValue;

        if (Dict.Count() == 0) return "";

        // does contain the key not the timestamp , as part of the key
        if (!Dict.ContainsKey((key, timestamp)))
        {
            // in the case that they KEY is not present this line shouldn't trigger
            var matchingRecords = Dict.Where(x => x.Key.Item1 == key && x.Key.Item2 <= timestamp).ToList();

            if(matchingRecords.Count() == 0)
            {
                return "";
            }

            var prevTimestamp = matchingRecords.Max(x => x.Key.Item2);

            returnValue = Dict[(key, prevTimestamp)];
        }
        else
        {
            returnValue = Dict[(key, timestamp)];
        }
        return returnValue;
    }
}