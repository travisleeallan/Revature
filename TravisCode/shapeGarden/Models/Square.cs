using ShapeGarden.Interfaces;
using ShapeGarden.Abstracts;

namespace ShapeGarden.Models
{
  public class Square : Rectangle
  {
    public new double Volume()  //this is an exception to the volume method for this particular class
    {
      return 0;
    }
    public double Perimeter(double x) //override of virtual method from AShape
    {
      return 0;
    }
  }
}