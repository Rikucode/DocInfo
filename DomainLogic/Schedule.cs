﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLogic
{
    public class Schedule
    {
        int doctorId { get; set; }
        TimeOnly workdayStart;
        TimeOnly workdayEnd;
    }
}
