public class Solution {
    public bool SearchMatrix(int[][] matrix, int target)
    {
            var numberOfRows = matrix.Count();

            for(int i = 0; i < numberOfRows; i++)
            {
                int l = 0;
                int r = matrix[i].Length - 1;

                while (l <= r)
                {
                    int middleIndex = (r + l) / 2;

                    var middleValue = matrix[i][middleIndex];

                    if (middleValue < target)
                    {
                        l = middleIndex + 1;
                    }
                    else if (middleValue > target)
                    {
                        r = middleIndex - 1;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
            return false;
    }
}
