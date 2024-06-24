using System;

public static class Kata
{
  public static string Greet(string name)
  {
    if(string.IsNullOrEmpty(name)) {
      return "Hello!";
    }
    
    string lowered = name.ToLower();
    string res = char.ToUpper(lowered[0]) + lowered.Substring(1);
    
    return $"Hello {res}!";
  }
}
