using System.Threading;
namespace Radio.Src

{
  public class XmRadio
  {
    public delegate void RadioSignal();
    public event RadioSignal MicHandler;

    private static XmRadio _instance = new XmRadio();
    private XmRadio() 
    {
      //_instance = new XmRadio(0;)
    }

    public static XmRadio Instance
    {
      get
      {
        //c# 4-
        lock (_instance) {
          if (_instance == null)
          {
            _instance = new XmRadio();
          }
        }
      
        //c# 5+
        if (_instance == null)
        {
          _instance = new XmRadio();
        }
        return new XmRadio();
      }
    }
    public void Broadcast()
    {
      var count = 1;

      while (count < 6 ) 
      {
        Thread.Sleep(2000);
        System.Console.WriteLine("playing Music");

        if (MicHandler != null) 
        {
          MicHandler();
        }        
        count += 1;
      }
    }
  }
}