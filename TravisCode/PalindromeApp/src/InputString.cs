using System;

namespace PalindromeApp.Src
{
  public class InputString 
  {
    public string Content { get; set; }
  
    public void string Formatter() 
    {
      Content = Content.Replace(" ", "");
      System.Console.WriteLine(Content);
    }
  }
}