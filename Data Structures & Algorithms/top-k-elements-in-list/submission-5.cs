public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> dict = new Dictionary<int,int>();

        foreach(int num in nums){
            if(dict.ContainsKey(num)){
                dict[num]++;
            }
            else {
                dict[num] = 1;
            }
        }

        dict = dict.OrderByDescending(p => p.Value).ToDictionary();

        var res = new int[k];
        int index = 0;
       
       foreach((var key, var val) in dict) {
            if(k <= 0) return res;

            res[index] = key;

            index++;
            k--;
       }

       return res;
    }
}
