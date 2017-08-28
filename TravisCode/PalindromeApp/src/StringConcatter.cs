using System;

namespace PalendromeApp.Src
{
  public class StringConcatter 
  {
    public string Formatter(string s) 
    {
      s = s.Replace(" ", "");
      System.Console.WriteLine(s);
      return s;
    }
  }
}