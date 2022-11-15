namespace codesignal.Arcade.Core.AtTheCrossroads
{
    // You're given three integers, a, b and c. It is guaranteed that two of these integers are equal to each other. What is the value of the third integer?
    // Example
    // For a = 2, b = 7, and c = 2, the output should be
    // solution(a, b, c) = 7.
    // The two equal numbers are a and c. The third number (b) equals 7, which is the answer.
    // Input/Output
    // [execution time limit] 0.5 seconds (cs)
    // [input] integer a
    // Guaranteed constraints:
    // 1 ≤ a ≤ 109.
    // [input] integer b
    // Guaranteed constraints:
    // 1 ≤ b ≤ 109.
    // [input] integer c
    // Guaranteed constraints:
    // 1 ≤ c ≤ 109.
    // [output] integer
    public static class ExtraNumber
    {
        public static int solution(int a, int b, int c)
        {
            if (a == c) return b;
            else if (a == b) return c;
            else return a;
        }
    }
}