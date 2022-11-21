namespace codesignal.Arcade.Core.ListForestEdge
{
    // Given an array of integers, replace all the occurrences of elemToReplace with substitutionElem.
    // Example
    // For inputArray = [1, 2, 1], elemToReplace = 1, and substitutionElem = 3, the output should be
    // solution(inputArray, elemToReplace, substitutionElem) = [3, 2, 3].
    public static class ArrayReplace
    {
        public static int[] solution(int[] inputArray, int elemToReplace, int substitutionElem)
        {
            for (int i = 0; i < inputArray.Length; ++i)
            {
                if (inputArray[i] == elemToReplace)
                    inputArray[i] = substitutionElem;
            }
            
            return inputArray;
        }
    }
}