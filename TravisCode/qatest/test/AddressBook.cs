using Xunit;
using QATest.Src;
using System;

namespace QATest.Test
{
   
  public class AddressBook
  {
    [Fact]
    public void AddTest()
    {
      //arrange
      var p = new Person() { Id = 1, First = "Travis", Last = "Allan" };
      //act
      var actual = Contacts.Add(p);
      

      //assert
      Assert.True(actual);
    }

    [Fact]
    public void UpdateTest()
    {
      Person p = new Person() { Id = 1, First = "Travis", Last = "Allan" };

      Person actual = Contacts.Update(p);

      Assert.Equal(actual.Id, p.Id);
      Assert.Equal(actual.First, p.First);
      Assert.Equal(actual.Last, p.Last);
    }
    
    [Fact]
    public void DeleteTest()
    {

    }
    
    [Fact]
    public void ListTest()
    {

    }

    public void CheckLocale() 
    {
      var p = new Person();

      p.DisplayName(USFullName);
    }

    Func<string, string, string> USFullName = (string f, string l) => { return f + " " + l;};
    Func<string, string, string> EUFullName = (string f, string l) => { return l + " " + f;};

    //Action<string, string> FullName = (string q, string w) { };
    
  }
}