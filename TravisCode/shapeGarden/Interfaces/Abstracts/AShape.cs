//abstract class between IShape and the the shape classes
//why is this class needed?
using ShapeGarden.Interfaces;

namespace ShapeGarden.Abstracts 
{
  public abstract class AShape : IShape 
  {
    //public int Sides { get; protected set; } //property protected set prevents the variable sides from being modified outside of the classes
    public int Sides { get; } //knows what it needs to be when it is called
    protected AShape(int s)  //constructor
    {
        Sides = s;
    }
    public double Volume() // "static" can't be changed by child classes
    {
      throw new System.NotImplementedException();
    }

    public virtual double Perimeter() //in virtual change is encouraged, can be redifined by the child classes
    {
      //throw new System.NotImplementedException();
      return Sides;
    }

    public abstract double Surface(); //abstract must be defined by the child classes
  }
}