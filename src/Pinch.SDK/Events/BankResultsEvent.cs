﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pinch.SDK.Payments;

namespace Pinch.SDK.Events
{
    public class BankResultsEvent
    {
        public IEnumerable<Dishonour> Dishonours { get; set; }

        public BankResultsEvent()
        {
            Dishonours = new List<Dishonour>();
        }
    }
}
