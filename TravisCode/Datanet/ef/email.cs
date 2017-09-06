using System;
using System.Collections.Generic;

namespace Datanet.EF
{
    public partial class email
    {
        public int Emailid { get; set; }
        public int ContactId { get; set; }
        public string Address { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ChangeDate { get; set; }
        public bool? ActiveFlag { get; set; }
    }
}
