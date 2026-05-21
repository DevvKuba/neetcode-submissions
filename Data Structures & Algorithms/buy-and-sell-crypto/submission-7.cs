public class Solution {
    public int MaxProfit(int[] prices) {
        int maxProfit = 0;

        int l = 0;
        int r = l + 1;

        while(l < prices.Length - 1 && r < prices.Length)
        {
            int currentProfit = prices[r] - prices[l];

            if(currentProfit > maxProfit)
            {
                maxProfit = currentProfit;
            }

            if (prices[l] > prices[r])
            {
                l++;
            }
            else if (prices[l] <= prices[r])
            {
                r++;
            }
        }
        return maxProfit;
    }
}
