using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLogic.Models
{
    public class Appointment
    {
        DateTime appointmentStart;
        DateTime appointmentEnd;
        int patientId { get; set; }
        int doctorId { get; set; }
    }
}
