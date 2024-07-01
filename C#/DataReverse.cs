namespace Main{

using System;
using System.Collections.Generic;
public class Kata
{
  public static int[] DataReverse(int[] data)
  {
    int bits = 8;
    int totalBytes = data.Length / bits;
    List<int[]> bytes = new List<int[]>();
    int[] result = new int[data.Length];
    
    for(int i = 0; i < totalBytes; i++) {
      int[] bytey = new int[bits];
      Array.Copy(data, i * bits, bytey, 0, bits);
      bytes.Add(bytey);
    }
    
    bytes.Reverse();
    
    for(int k = 0; k < totalBytes; k++) {
      Array.Copy(bytes[k], 0, result, k * bits, bits);
    }
    
    return result;
  }
}
}
