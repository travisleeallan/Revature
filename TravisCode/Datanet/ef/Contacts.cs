using System;
using System.Collections.Generic;

namespace Datanet.EF
{
    public partial class Contacts
    {
        public Contacts()
        {
            Emails = new HashSet<Emails>();
            Phones = new HashSet<Phones>();
        }

        public int ContactId { get; set; }
        public string Myproperty { get; set; }

        public ICollection<Emails> Emails { get; set; }
        public ICollection<Phones> Phones { get; set; }
    }
}
