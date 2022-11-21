namespace codesignal.Arcade.Core.ListForestEdge
{
    // Remove a part of a given array between given 0-based indexes l and r (inclusive).
    // Example
    // For inputArray = [2, 3, 2, 3, 4, 5], l = 2, and r = 4, the output should be
    // solution(inputArray, l, r) = [2, 3, 5].
    public static class RemoveArrayPart
    {
        public static int[] solution(int[] inputArray, int l, int r)
        {
            var removed = r - l + 1;
            var newArray = new int[inputArray.Length - removed];
            var j = 0;
            for (int i = 0; i < inputArray.Length; ++i)
            {
                if (i >= l && i <= r) continue;
                newArray[j] = inputArray[i];
                ++j;
            }
            
            return newArray;
        }
    }
}