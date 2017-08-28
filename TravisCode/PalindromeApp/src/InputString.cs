using System;

namespace PalindromeApp.Src
{
  public class InputString 
  {
    public string Content { get; set; }

    public void RMspace() 
    {
      Content = Content.Replace(" ", "");
      //System.Console.WriteLine(Content);
    }

    public bool IsPalindrome() 
    {
      int count = 0;
      for (int i = 0; i <= Content.Length; i++)
      {
        if (Content[i] == Content[Content.Length - i]) 
        {
          count++;
        }
      }
      if (count == Content.Length)
      {
        return true;
      }
      else return false;
    }
  }
}