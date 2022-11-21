namespace codesignal.Arcade.Core.ListForestEdge
{
    // Given an integer size, return array of length size filled with 1s.
    // Example
    // For size = 4, the output should be
    // solution(size) = [1, 1, 1, 1].
    public static class CreateArray
    {
        public static int[] solution(int size)
        {
            var array = new int[size];
            for (int i = 0; i < size; ++i)
                array[i] = 1;
            return array;
        }
    }
}