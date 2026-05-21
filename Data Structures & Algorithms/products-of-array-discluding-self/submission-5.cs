public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] res = new int[nums.Length];
        List<int?> ints = new List<int?>();

        for (int i = 0; i < nums.Length; i++)
        {
            int? prod = null;
            // access all index's but it's current one
            for(int j = 0; j < nums.Length; j++)
            {
                if (j != i)
                {
                    if(prod is not null)
                    {
                        prod *= nums[j];
                    }
                    else
                    {
                        prod = nums[j];
                    }
                }
            }
            ints.Add(prod);
        }

        for(int i = 0; i < nums.Length; i++)
        {
            res[i] = (int)ints[i];
        }

        return res;
    }
}
