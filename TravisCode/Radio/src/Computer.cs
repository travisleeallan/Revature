namespace Radio.Src 
{
  public class Computer 
  {
    private List<Hardware> stuff = new List<Hardware>();

    protected Computer()
    {
      BuildComputer();
    }

    protected abstract void BuildComputer() 
    {
      stuff.Add(new Keyboard);
      stuff.Add(new Monitor);
      stuff.Add(new Hardrive);
      
    }
  }

  public class Gaming : Computer {}

  public class Business : Computer {}
}