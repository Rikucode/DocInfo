using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLogic.Models
{
    public class Schedule
    {
        int doctorId { get; set; }
        Doctor Date;
        TimeOnly workdayStart;
        TimeOnly workdayEnd;
    }
}
