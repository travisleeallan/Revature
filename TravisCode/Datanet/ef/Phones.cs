﻿using System;
using System.Collections.Generic;

namespace Datanet.EF
{
    public partial class Phones
    {
        public int PhoneId { get; set; }
        public int? ContactId { get; set; }
        public string Number { get; set; }

        public Contacts Contact { get; set; }
    }
}
