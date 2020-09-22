using Microsoft.VisualStudio.TestTools.UnitTesting;
using Word;

namespace Word.Tests
{
  [TestClass]

  public class PalindromeTests
  {
    [TestMethod]
    public void ToPalindrome_ReturnsStringBackwards_Hello()
    {
      Palindrome testPalindrome = new Palindrome();
      Assert.AreEqual("olleh", testPalindrome.ToPalindrome("hello"));
    }

    [TestMethod]
    public void IsPalindrome_IsPhraseAPalindrome_Hello()
    {
      Palindrome testPalindrome = new Palindrome();
      Assert.AreEqual(false, testPalindrome.IsPalindrome(testPalindrome.ToPalindrome("hello"), "hello"));
    }
  }
}