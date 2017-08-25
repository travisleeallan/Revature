using System;

namespace QATest.Src
{
  public class Person
  {
    public int Id { get; set; }
    public string First { get; set; }
    public string Last { get; set; }

    public delegate string NameFormat(string a, string z);
    public delegate void NameFormatBlank(string a, string z);


    

    public void DisplayName(NameFormat name) //method looks like an object, so it can be passed to another method
      {
        System.Console.WriteLine(name(First, Last));
      }
  }
}