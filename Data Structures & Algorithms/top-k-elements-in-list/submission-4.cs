public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
         Dictionary<int, (int, int)> dict = new Dictionary<int, (int, int)>();
        int[] topKElements = new int[k];

        for(int i = 0; i < nums.Length; i++)
        {
            if (dict.ContainsKey(nums[i]))
            {
                var newCount = dict[nums[i]].Item2 + 1;
                dict[nums[i]] = (dict[nums[i]].Item1, newCount);
                
            }
            else
            {
                dict[nums[i]] = (i, 1);
            }
        }
        int arrayPosition = 0;
        while(k > 0)
        {
            var maxCount = dict.Values.Where(x => x.Item2 == dict.Values.Max(x => x.Item2)).First();
            var maxValue = nums[maxCount.Item1];
            dict.Remove(maxValue);
            topKElements[arrayPosition] = maxValue;
            k--;
            arrayPosition++;
        }

        return topKElements;
    }
}
