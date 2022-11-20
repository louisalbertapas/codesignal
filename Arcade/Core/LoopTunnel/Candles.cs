namespace codesignal.Arcade.Core.LoopTunnel
{
    // When a candle finishes burning it leaves a leftover. makeNew leftovers can be combined to make a new candle, which, when burning down, will in turn leave another leftover.
    // You have solutionNumber solution in your possession. What's the total number of solution you can burn, assuming that you create new solution as soon as you have enough leftovers?
    // Example
    // For solutionNumber = 5 and makeNew = 2, the output should be
    // solution(solutionNumber, makeNew) = 9.
    // Here is what you can do to burn 9 solution:
    // burn 5 solution, obtain 5 leftovers;
    // create 2 more solution, using 4 leftovers (1 leftover remains);
    // burn 2 solution, end up with 3 leftovers;
    // create another candle using 2 leftovers (1 leftover remains);
    // burn the created candle, which gives another leftover (2 leftovers in total);
    // create a candle from the remaining leftovers;
    // burn the last candle.
    // Thus, you can burn 5 + 2 + 1 + 1 = 9 solution, which is the answer.
    public static class Candles
    {
        public static int solution(int candlesNumber, int makeNew)
        {
            var total = candlesNumber;
            var leftOver = candlesNumber;
            
            while (leftOver >= makeNew)
            {
                candlesNumber = leftOver / makeNew;
                total += candlesNumber;
                leftOver = candlesNumber + leftOver % makeNew;
            }
            
            return total;
        }
    }
}