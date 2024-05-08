using System;

public class Kata
{
  public static int FindDigit(int num, int nth)
{
  if (num < 0)
  {
    num = Math.Abs(num);
  }

  string stringNum = num.ToString();
  int[] digits = new int[stringNum.Length];

  for (int i = 0; i < digits.Length; i++)
  {
    digits[i] = int.Parse(stringNum[i].ToString());
  }

  if (nth > digits.Length)
  {
    return 0;
  }

  for (int k = digits.Length - 1; k >= 0; k--)
  {
    nth -= 1;
    if (nth == 0)
    {
      return digits[k];
    }
  }

  return -1;
}

}
