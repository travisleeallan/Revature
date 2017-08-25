using System.Threading;
using System.Threading.Tasks;

using System.Collections.Generic;
namespace Radio.Src
{
    public class AsyncPro 
    {
        private Dictionary<string, string> TStatus = new Dictionary<string, string>();

        public void ThreadParty()
        {
            var t1 = new Thread(() => {
                DoSomething("t1", "A");
            });
            var t2 = new Thread(() => {
                DoSomething("t2", "B");
            });
            t1.Start();
            t2.Start();

            DoSomething("t0", "1");

            if (t1.IsAlive) {

            }
            t1.Join();
            t2.Join();
            
            foreach ( var item in TStatus) 
            {
                System.Console.WriteLine("{0}: {1}", item.Key, item.Value);
            }

        }

        public void TaskParty() 
        {
            var t1 = new Task(() => {
                DoSomething("t1", "A");
            }, new CancellationToken(true));

            var t2 = new Task(() => {
                DoSomething("t2", "B");
            }, new CancellationToken(true));

            DoSomething("t0", "0");

            t1.Start();
            t2.Start();

            t1.ConfigureAwait(true);
            t2.ConfigureAwait(true);

            t1.ContinueWith((Task t) => {System.Console.WriteLine("cancelled t1");});
            t2.ContinueWith((Task t) => {System.Console.WriteLine("cancelled t2");});

            Task.WaitAny(new Task[]{t1, t2}, 10);
            //Task.WaitAny(new Task[]{t1, t2}, 500);
            //Task.WaitAll(t1, t2);

            foreach ( var item in TStatus) 
            {
                System.Console.WriteLine("{0}: {1}", item.Key, item.Value);
            }

        }

        public Task AsyncParty() {
            return Task.Run(() => {
                T1Async().Start();
                T2Async().Start();
                DoSomething("t0", "0");
            });
    
        }
        private Task T1Async() {
            return new Task(() =>
            {
                //var ap = new AsyncPro();
                DoSomething("t1", "A");
            });
        }

        private Task T2Async() {
            return new Task(() =>
            {
                //var ap = new AsyncPro();
                DoSomething("t2", "A");
            });
        }

        public void DoSomething(string t, string s)
        {
            for(var x =0; x < 10; x++) 
            {
                System.Console.Write(s);
            }

            TStatus[t] = "done";
        }
    } 
}