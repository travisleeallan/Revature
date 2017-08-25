using System;

namespace ShapeGarden.Models
{

  public class ShapeList<T> where T : IShape
  {
    private T[] collection = new T[4];
    private int count = 0;

    public void Add(T u)
    {
      collection[count] = u;
      count += 1;
    }
    public void Remove(T u)
    {
      T temp;

      foreach (var i in collection)
      {
        if (i.Sides == u.Sides) //dumb shit
        {
          temp = i;
          break;
          
        }
      }
    }
  }

  public class WorkWithGenerics
  {
    public void Play()
    {
      var g = new ShapeList<int>();

      g.Add(5);
      g.Remove(10);
    }
  }
}