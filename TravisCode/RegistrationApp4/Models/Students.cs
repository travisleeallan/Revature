using System;
using System.Collections.Generic;

namespace RegistrationApp4
{
    public partial class Students
    {
        public int Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Classification { get; set; }
        public string Major { get; set; }
        public int? NumClasses { get; set; }
    }
}
