using System;

public static class Kata
{
  public static int Factorial(int n)
  {
    if (n < 0 || n > 12)
    {
      throw new ArgumentOutOfRangeException(nameof(n), "Input must be between 0 and 12 inclusive.");
    }
    
    int res = 1;
    while(n > 0) {
      res *= n;
      n -= 1;
    }
    
    return res;
  }
}
