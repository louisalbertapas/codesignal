namespace codesignal.Arcade.Core.LoopTunnel
{
    // You have k apple boxes full of apples. Each square box of size m contains m × m apples. You just noticed two interesting properties about the boxes:
    // The smallest box is size 1, the next one is size 2,..., all the way up to size k.
    // Boxes that have an odd size contain only yellow apples. Boxes that have an even size contain only red apples.
    // Your task is to calculate the difference between the number of red apples and the number of yellow apples.
    // Example
    // For k = 5, the output should be
    // solution(k) = -15.
    // There are 1 + 3 * 3 + 5 * 5 = 35 yellow apples and 2 * 2 + 4 * 4 = 20 red apples, making the answer 20 - 35 = -15.
    public static class AppleBoxes
    {
        public static int solution(int k)
        {
            var sumOdd = 0;
            var sumEven = 0;
            
            for (int i = 1; i <= k; ++i)
            {
                if (i % 2 == 0) sumEven += i * i;
                else sumOdd += i * i;
            }
            
            return sumEven - sumOdd;
        }
    }
}