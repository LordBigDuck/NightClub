﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NightClub.Core.Domains
{
    public class Blacklist
    {
        public int Id { get; set; }
        public Member Member { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
