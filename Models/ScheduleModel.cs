using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ScheduleModel
    {
        public int id { get; set; }
        public int doctor_id { get; set; }
        public DateOnly date;
        public TimeOnly workdayStart;
        public TimeOnly workdayEnd;

    }
}
