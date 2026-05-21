public class Solution {
    public int CarFleet(int target, int[] position, int[] speed)
{
    // list of the (position , speed)
    var collection = new List<(int, int)>();

    // stack containing time until target
    var fleets = new Stack<double>();

    for(int i = 0; i < position.Length; i++)
    {
        collection.Add((position[i], speed[i]));
    }

    var orderedCollection = collection.OrderByDescending(p => p.Item1).ToList();

    for(int i = 0; i < collection.Count; i++)
    {
        double timeUntilTarget = (target - (double)orderedCollection[i].Item1) / orderedCollection[i].Item2;

        if(fleets.Count == 0)
        {
            fleets.Push(timeUntilTarget);
        }
        else
        {
            var aheadTimeUntilTarget = fleets.Peek();

            if(timeUntilTarget > aheadTimeUntilTarget)
            {
                fleets.Push(timeUntilTarget);
            }
        }
    }

    return fleets.Count();

}
}
