using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLogic
{
    public class Schedule
    {
        public int id { get; set; }
        public int doctorId { get; set; }
        public DateOnly date;
        public TimeOnly workdayStart;
        public TimeOnly workdayEnd;
    }
}
