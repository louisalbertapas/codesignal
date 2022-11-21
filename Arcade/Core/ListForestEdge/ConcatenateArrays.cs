namespace codesignal.Arcade.Core.ListForestEdge
{
    // Given two arrays of integers a and b, obtain the array formed by the elements of a followed by the elements of b.
    // Example
    // For a = [2, 2, 1] and b = [10, 11], the output should be
    // solution(a, b) = [2, 2, 1, 10, 11].
    public static class ConcatenateArrays
    {
        public static int[] solution(int[] a, int[] b)
        {
            var newArray = new int[a.Length + b.Length];
            var i = 0;
            for (i = 0; i < a.Length; ++i)
            {
                newArray[i] = a[i];
            }
            for (int j = 0; j < b.Length; ++j)
            {
                newArray[i] = b[j];
                ++i;
            }
            
            return newArray;
        }
    }
}