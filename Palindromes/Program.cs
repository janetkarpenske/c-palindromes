using System;
using System.Collections.Generic;
using NoRevWord;

namespace NoRevWord
{
  public class Program
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