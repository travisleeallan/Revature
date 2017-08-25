using ShapeGarden.Interfaces;
using ShapeGarden.Abstracts;

namespace ShapeGarden.Models
{
  public class Circle : AShape
  {
    public Circle() : base(int.MaxValue) {}

    public override double Surface() //definition of Surface method
    {
      throw new System.NotImplementedException();
    }
  }
}