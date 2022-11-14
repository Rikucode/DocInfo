using DomainLogic;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public static class AppointmentModelToRepository
    {
        public static Appointment? ToDomain(this AppointmentModel model)
        {
            return new Appointment
            {
                id = model.id,
                appointmentStart = model.appointment_start,
                appointmentEnd = model.appointment_end,
                doctorId = model.doctor_id,
                patientId = model.patient_id
            };
        }
        public static IEnumerable<Appointment>? ToDomain(this List<AppointmentModel> model)
        {
            List<Appointment>? result = new List<Appointment>();
            foreach (AppointmentModel am in model)
            {
                result.Add(am.ToDomain());
            }
            return result;
        }
    }
}
