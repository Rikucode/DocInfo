using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLogic
{
    public class Appointment
    {
        public int id { get; set; }
        public DateTime appointmentStart;
        public DateTime appointmentEnd;
        public int patientId { get; set; }
        public int doctorId { get; set; }
    }
}
