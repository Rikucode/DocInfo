using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class AppointmentModel
    {
        public int id { get; set; }
        public DateTime appointment_start;
        public DateTime appointment_end;
        public bool is_free;
        public int patient_id { get; set; }
        public int doctor_id { get; set; }
        public int speciality_id { get; set; }
    }
}
