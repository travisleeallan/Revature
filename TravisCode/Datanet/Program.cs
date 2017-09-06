using System;
using System.Linq;
using Datanet.Ado;
using Datanet.EF;
namespace Datanet
{
    class Program
    {
        static void Main(string[] args)
        {
            //PlayWithAdo();
            //System.Console.WriteLine(" ");
            //PlayWithAdo2();
            PlayWithEFCodeFirst();
        }

        public static void PlayWithAdo()
        {
            var actor = new AdoData();
            actor.ReadDisconnected();
        }
        public static void PlayWithAdo2()
        {
            var actor = new AdoData();
            actor.ReadConnected();
        }

        public static void PlayWithEFCodeFirst()
        {
            var ef = new SqlWeek3();
            ef.Contacts.Add(new Contact(){First = "Travis", Last = "Allan"});
            ef.SaveChanges();

            var contacts = ef.Contacts.ToList();

            System.Console.WriteLine(contacts.First());
        }

        public static void PlayWithEFDatabaseFirst()
        {
            var ef = new TLARevDB1Context();
            //ef.Contacts.Add(new Contacts() { First = "fred1", Last = "belotte1"});
            var contacts = ef.Contacts.ToList();
            foreach (var item in contacts)
            {
                System.Console.WriteLine(contacts.First());
            } 
        }
    }
}
