public static class Kata
{
  public static bool IsPrime(int n)
  {
    if(n <= 1) {
      return false;
    }
    
    for(int i = 2; i < n; i++) {
      if(n % i == 0) {
        return false;
      }
    }
    return true;
  }
}
