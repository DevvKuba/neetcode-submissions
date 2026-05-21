public class Solution {
   public  int MinEatingSpeed(int[] piles, int h)
{
    int maxValue = piles.Max(x => x);
    int timeTaken = 0;

    int l = 1, r = maxValue;
    int res = r;

    int k = 0;
    while (l <= r)
    {
        k = (l + r) / 2;

        foreach (int pile in piles)
        {
            // rounds decimal number up
            timeTaken += (int)Math.Ceiling((double)pile / k);
        }
        if (timeTaken <= h)
        {
            r = k - 1;
            res = Math.Min(res, k);
        }
        else
        {
            l = k + 1;
        }
        timeTaken = 0;

    }

    return res;

}
}

