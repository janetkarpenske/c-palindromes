namespace NoRevWord
{
  public class Palindrome
  {
    public string ToPalindrome(string phrase)
    {
      char[] charArray = phrase.ToCharArray();
      string getString = "";
      for (int i = charArray.Length - 1; i >= 0; i--)
      {
        getString = getString + charArray[i];
      }
      return getString;
    }

    public bool IsPalindrome(string toString, string phrase)
    {
      return toString == phrase;
      
    }
  }
}