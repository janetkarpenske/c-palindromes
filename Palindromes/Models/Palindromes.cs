using System;

namespace Word
{
  public class Palindrome
  {
    public string ToPalindrome(string phrase)
    {
      char[] charArray = phrase.ToCharArray();
      Array.Reverse(charArray);
      string toString = new string(charArray);
      return toString;
    }

    public bool IsPalindrome(string toString, string phrase)
    {
      return toString == phrase;
      
    }
  }
}