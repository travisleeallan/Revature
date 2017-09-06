using System;
using System.Collections.Generic;

namespace Datanet.EF
{
    public partial class Emails
    {
        public int EmailId { get; set; }
        public int? ContactId { get; set; }
        public string Myproperty { get; set; }

        public Contacts Contact { get; set; }
    }
}
