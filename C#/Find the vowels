using System;
using System.Collections.Generic;

public class Kata
{
  public static int[] VowelIndices(string word)
  {
    char[] vowels = {'a','e','i','o','u','y'};
    string lowerCaseWord = word.ToLower();
    char[] letters = lowerCaseWord.ToCharArray();
    
    List<int> lmao = new List<int>();
    
    for(int i = 0; i < letters.Length; i++) {
      if(Array.IndexOf(vowels, letters[i]) != -1) {
        lmao.Add(i + 1);
      }
    }
    
    return lmao.ToArray();
  }
}
