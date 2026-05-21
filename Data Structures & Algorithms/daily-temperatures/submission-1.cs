public class Solution {
   public int[] DailyTemperatures(int[] temperatures)
{
    int[] res = new int[temperatures.Count()];

    for (int i = 0; i < temperatures.Length; i++)
    {
        int counter = 0;
        for (int j = i + 1; j < temperatures.Length; j++)
        {
            counter++;
            if (temperatures[j] > temperatures[i])
            {
                res[i] = counter;
                break;
            }
        }
    }

    return res;

}
}
