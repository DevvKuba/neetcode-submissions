public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
            List<List<int>> res = new List<List<int>>();
            // sort input array 
            Array.Sort(nums);

            for(int i = 0; i < nums.Length; i++)
            {
                // if (nums[i] > 0) break;
                if (i > 0 && nums[i] == nums[i - 1]) continue;
                // what do these two ensure ?

                int l = i + 1; // next index
                int r = nums.Length - 1; // last index

                while(l < r)
                {
                    var sum = nums[i] + nums[l] + nums[r];

                    if(sum > 0)
                    {
                        r--;
                    }
                    else if(sum < 0)
                    {
                        l++;
                    }
                    else
                    {
                        List<int> newList = new List<int> { nums[i], nums[l], nums[r] };
                        if (!res.Contains(newList))
                        {
                            res.Add(newList);
                            l++;
                            r--;
                            while(l < r && nums[l] == nums[l -1])
                            {
                                l++;
                            }
                        }
                    }
                }
            }

            return res;
        }
}
