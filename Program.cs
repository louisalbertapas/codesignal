bool core43(int n)
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

void main()
{
  Console.WriteLine("Select from the following methods above on which to run.");
  var result = core43(125);
  Console.WriteLine(result);
}

main();
