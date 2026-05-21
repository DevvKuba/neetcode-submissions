public class Solution {
    public int CarFleet(int target, int[] position, int[] speed)
{
    // one value in formula needs to be a decimal otherwise it will result to integer division
    decimal dTarget = (decimal)target;
    List<(int, int)> carsDetails = new List<(int, int)>();

    for (int i = 0; i < position.Length; i++)
    {
        carsDetails.Add((position[i], speed[i]));
    }

    List<(int, int)> descendingDetails = carsDetails.OrderByDescending(x => x.Item1).ToList();
    int fleetsCounter = 0;
    Stack<decimal> stack = new Stack<decimal>();

    for (int i = 0; i < descendingDetails.Count; i++)
    {
        decimal time = (dTarget - descendingDetails[i].Item1) / descendingDetails[i].Item2;
        if (stack.Count == 0 || time > stack.Peek())
        {
            stack.Push(time);
            fleetsCounter++;
        }

    }

    return fleetsCounter;


}
}
