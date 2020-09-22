using System;
using System.Collections.Generic;
using Word;

namespace Program
{
  public class Initialize
  {
    public static void Main()
    {
      Console.WriteLine("Enter a word: ");
      Palindrome phrase = new Palindrome();
      string input = Console.ReadLine();
      Console.WriteLine(phrase.IsPalindrome(phrase.ToPalindrome(input), input));
    }
  }
}