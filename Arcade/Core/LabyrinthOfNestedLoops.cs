namespace codesignal.Arcade.Core.LabyrinthOfNestedLoops
{
    public static class LabyrinthOfNestedLoops
    {
        public static bool IsPower(int n)
        {
            if (n == 1) return true;
            for (int i = 2; i <= 20; ++i)
            {
                int b = i * i;
                while (b <= n)
                {
                    if (b == n)
                    return true;

                    b *= i;
                }
            }

            return false;
        }
    }
}