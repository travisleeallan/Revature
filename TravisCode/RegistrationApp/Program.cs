using System;
using System.Linq;
using RegistrationApp.EF;
using System;

namespace RegistrationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            DoEFCodeFirst();
        }
        public static void DoEFCodeFirst()
        {
            var ef = new SchedulerAppDB();
            //ef.Contacts.Add(new Contact(){First = "Travis", Last = "Allan"});
            ef.SaveChanges();

            //var contacts = ef.Contacts.ToList();

            //System.Console.WriteLine(contacts.First());
        }
    }
}
