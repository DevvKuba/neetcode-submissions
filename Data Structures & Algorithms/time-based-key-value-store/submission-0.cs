public class TimeMap
{
    public Dictionary<(string, int), string> Dict { get; set; }


    public TimeMap()
    {
        Dict = new Dictionary<(string, int), string>();
    }

    public void Set(string key, string value, int timestamp)
    {
        Dict.Add((key, timestamp), value);
    }

    public string Get(string key, int timestamp)
    {
        if (Dict.ContainsKey((key, timestamp)))
        {
            return Dict[(key, timestamp)];
        }
        else
        {
            int pastTimeStamp = timestamp - 1;
            while (pastTimeStamp > 0)
            {
                if (Dict.ContainsKey((key, pastTimeStamp)))
                {
                    return Dict[(key, pastTimeStamp)];
                }
                pastTimeStamp--;
            }
        }

        return "";
    }
}
