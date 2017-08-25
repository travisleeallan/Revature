using ShapeGarden.Interfaces;
using ShapeGarden.Abstracts;

namespace ShapeGarden.Models
{
  public class Triangle : AShape
  {
    public Triangle() : base(3) {}

    public override double Surface() //definition of Surface method
    {
      throw new System.NotImplementedException();
    }
  }
}