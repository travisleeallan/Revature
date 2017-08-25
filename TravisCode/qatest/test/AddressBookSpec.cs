using System;
using QATest.Src;
using Machine.Specifications;
using FluentAssertions;

namespace QATest.Test

{
   
  public class AddressBookSpec
  {
    private static Person p;


    private Establish context = () =>
    {
      p = new Person() { Id = 0, First = "Travis", Last = "Allan" };
    };

    private Because of = () =>
    {
      Contacts.Add(p);
    };

    private It should_have_a_person = () => 
    {
      Contacts.List().Count.Should().Be(1);
      Contacts.List().Find(c => c.Id == p.Id).Should().NotBeNull();
      /*if (Contacts.List().Count < 1) 
      {
        throw new Exception();
      }
      if (Contacts.List().Find(c => c.Id == p.Id) == null)
      {
        throw new Exception();
      };*/
    };

    private void Context() {
      p = new Person() { Id = 0, First = "Travis", Last = "Allan" };
    }
  }
}