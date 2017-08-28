using System;
using System.Threading;
using Radio.Src;

namespace Radio
{
    class Program
    {
        static void Main()
        {
            //ThreadStuff();
            //TaskStuff();
            AsyncStuff();
            System.Console.WriteLine("Done!");
            Thread.Sleep(3000);
        
            System.Console.WriteLine(" ");

        }

        public static void EventStuff()
        {
            var r = new XmRadio().Instance;
            var s = new XmSub();
            s.Subscribe(r);
            r.Broadcast();
            s.Subscribe(r);
            r.Broadcast();

        }

        public static void ThreadStuff()
        {
            var ap = new AsyncPro();

            ap.ThreadParty();
            
        }

        public static void TaskStuff()
        {
            var ap = new AsyncPro();

            ap.TaskParty();
            
        }
        
        public static async void AsyncStuff() 
        {
            var ap = new AsyncPro();
            
            await ap.AsyncParty();
            //Thread.Sleep(5000);
        }

        public static void FactoryPattern()
        {
            var g = new Gaming : Computer;
            var h = new Business : Computer;

            foreach (var item in g.stuff)
            {
                System.Console.WriteLine(item)
            }
        }

        public static void FactoryofFactories() 
        {
            var g = n.Instance<Gaming>();

            var c = new Gaming();

            
        }
    }
}
