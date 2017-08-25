namespace QATest.src
{
  public class XmSub
  {
    public void Subscribe(XmRadio r)
    {
      r.MicHandler += Listening;
      r.MicHandler -= Listening;
    }

    private void Listening()
    {
      System.Console.WriteLine("playing Music");
    
    }
  }

}