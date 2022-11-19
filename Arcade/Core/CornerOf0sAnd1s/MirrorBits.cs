namespace codesignal.Arcade.Core.CornerOf0sAnd1s
{
    // Reverse the order of the bits in a given integer.
    // Example
    // For a = 97, the output should be
    // solution(a) = 67.
    // 97 equals to 1100001 in binary, which is 1000011 after mirroring, and that is 67 in base 10.
    // For a = 8, the output should be
    // solution(a) = 1.
    public static class MirrorBits
    {
        public static int solution(int a)
        {
            return (Convert.ToInt32(new string(Convert.ToString(a, 2).Reverse().ToArray()), 2));
        }
    }
}