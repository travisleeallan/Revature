using Xunit;
using PalindromeApp.Src;
using System;

namespace PalindromeApp.Test 
{
  public class PalindromeTest 
  {
    public void TestInput()
    {
      var input = new InputString() { Content = "never odd or even"};
      input = StringConcatter.Formatter(input.Content);
    }

  }
}