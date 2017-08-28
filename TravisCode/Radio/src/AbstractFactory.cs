namespace Radio.Src 
{
  public class AbstractFactory 
  {

  }

  public class ComputerFactory : AbstractFactory 
  {
    public Computer Instance<T>() where T : Computer, new()
    {
      var m = new Monitor();
      
      return new T();
    }
  }

  public class MonitorFactory : AbstractFactory {}


}