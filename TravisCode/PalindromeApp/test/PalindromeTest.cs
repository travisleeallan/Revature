using Xunit;
using PalindromeApp.Src;
using System;

namespace PalindromeApp.Test 
{
  public class PalindromeTest 
  {
    public void TestInput()
    {
      InputString input = new InputString() { Content = "never odd or even"};
      
      System.Console.WriteLine("{0}", input.Content);
    }
    public void TestExecution()
    {
      InputString input2 = new InputString() { Content = "never odd or even"};
      input2.RMspace();
      
      var res = input2.IsPalindrome();
      if (res == true) 
      {
        System.Console.WriteLine("The string: {0}, is a palindrome!", input2.Content);;
      }
      else System.Console.WriteLine("The string: {0}, is not a palindrome", input2.Content);
    }

  }
}