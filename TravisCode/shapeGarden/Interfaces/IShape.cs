//parent shape class
namespace ShapeGarden.Interfaces
{
  public interface IShape
  {
    int Sides { get; } //property

    double Perimeter();
    double Surface();
  }
}