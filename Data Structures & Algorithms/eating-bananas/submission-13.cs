public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
            int eatingSpeed = 0;

            int res = 0;

            int totalTime = 0;

            int l = 1;
            int r = piles.Max();

            while(l <= r)
            {
                totalTime = 0;

                eatingSpeed = (l + r) / 2;

                for (int i = 0; i < piles.Length; i++)
                {
                    var timeTaken = (int)Math.Ceiling(piles[i] / (decimal)eatingSpeed);
                    totalTime += timeTaken;
                }

                if (totalTime <= h)
                {
                    r = eatingSpeed - 1;
                    res = eatingSpeed;
                }

                else if (totalTime > h)
                {
                    l = eatingSpeed + 1;
                }
            }
            return res;
    }
}
