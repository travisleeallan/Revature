using ShapeGarden.Interfaces;
using ShapeGarden.Abstracts;

namespace ShapeGarden.Models
{
  public class Rectangle : AShape
  {
    public Rectangle() : base(4) {}
    
    public override double Surface() //definition of Surface method
    {
      throw new System.NotImplementedException();
    }

    ~Rectangle() //destructor
    {
      //any code you want here
    }
  }
}