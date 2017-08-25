using System.Collections.Generic;

namespace QATest.Src
{
  public static class Contacts
  {
    private static List<Person> pList = new List<Person>();
        
    public static bool Add(Person p)
    {
      try
      {
        pList.Add(p);
        return true;
      }
      catch
      {
        return false;
      }
      
      
    }

    public static Person Update(Person p)
    {
      var co = pList.Find(c => c.Id == p.Id);

      if (co != null) 
      {
        co = p;
      }
    
      return co;
      
    }

    //^^^^^ another way of doing this ^^^^^
    /*public Person Finder(Person p) {
      foreach (var item in pList)
      {
        if (item.Id == p.Id)
        {
          return item;
        }
      }
    }*/
    

    public static void Delete(Person p)
    {

    }

    public static List<Person> List()
    {
      return pList;
    }
  }
}