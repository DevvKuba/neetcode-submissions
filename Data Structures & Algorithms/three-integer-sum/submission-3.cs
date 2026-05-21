public class Solution {
    public List<List<int>> ThreeSum(int[] nums)
{
    List<List<int>> sumsList = new List<List<int>>();

    var orderedList = nums.OrderBy(x => x).ToList();

    for (int i = 0; i < orderedList.Count; i++)
    {
        // checks the past value to ensure it isn't same avoiding duplicates
        if (i > 0 && orderedList[i] == orderedList[i - 1])
        {
            continue;
        }
        int left = i + 1;
        int right = orderedList.Count - 1;

        while (left < right)
        {
            int threeSum = orderedList[i] + orderedList[left] + orderedList[right];

            if (threeSum > 0)
            {
                right--;
            }

            else if (threeSum < 0)
            {
                left++;
            }
            else
            {
                sumsList.Add(new List<int>
            {
                orderedList[i], orderedList[left], orderedList[right],
            });
            // adjusts pointer positions to avoid duplicates
            // since l net yet == to r we can through another while loop iteration
                left++;
                while (orderedList[left] == orderedList[left - 1] && left < right)
                {
                    left++;
                }


            }
        }
    }

    return sumsList;


}
}
