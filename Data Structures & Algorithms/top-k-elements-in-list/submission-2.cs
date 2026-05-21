public class Solution {
        public int[] TopKFrequent(int[] nums, int k){
        Dictionary<int, int> count = new Dictionary<int, int>();
        foreach (int n in nums)
        {
            if (count.ContainsKey(n))
            {
                count[n]++;
            }
            else
            {
                count[n] = 1;
            }
        }

        //for each entry of the dict we've creating a List of arrays with the value (count) + (key number)
        //[(1,1)(2,2)(3,3)] for instance 
        List<int[]> arr = count.Select(entry => new int[] { entry.Value, entry.Key }).ToList();
        //sorting each arr by is occurance values decending order - most frequent will come first
        arr.Sort((a, b) => b[0].CompareTo(a[0]));

        // only want k spaces in it
        int[] res = new int[k];
        for (int i = 0; i < k; i++)
        {
            res[i] = arr[i][1];
        }

        return res;

        }
}


