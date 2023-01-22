using DomainLogic.Services;
using DocInfo.Views;
using Microsoft.AspNetCore.Mvc;
using Models;
using DomainLogic;

namespace DocInfo.Controllers
{
    public class AppointmentController : ControllerBase
    {
        private readonly AppointmentService _service;
        public AppointmentController(AppointmentService service)
        {
            _service = service;
        }
        [HttpGet("add_appointment")]
        public ActionResult<DomainLogic.Appointment> AddAppointment(AppointmentModel appointment)
        {
            if (appointment.id <= 0 || appointment?.speciality_id == null || appointment?.doctor_id == null || appointment?.patient_id == null)
                return Problem(statusCode: 404, detail: "Не указаны все данные");
            var appointmentRes = _service.AddAppointment(appointment);
            if (appointmentRes.IsFailure)
                return Problem(statusCode: 404, detail: appointmentRes.Error);

            return Ok(appointmentRes);
        }
        [HttpGet("appointments_by_doctor")]
        public ActionResult<List<DomainLogic.Appointment>> GetAppointmentsByDoctorId(int id)
        {

            if (id <= 0)
                return Problem(statusCode: 404, detail: "Неправильный id");
            var appointmentRes = _service.GetAppointmentsByDoctorId(id);
            if (appointmentRes.IsFailure)
                return Problem(statusCode: 404, detail: appointmentRes.Error);

            return Ok(appointmentRes);
        }
        [HttpGet("appointment_by_id")]
        public ActionResult<DomainLogic.Appointment> GetAppointmentById(int id)
        {

            if (id <= 0)
                return Problem(statusCode: 404, detail: "Неправильный id");
            var appointmentRes = _service.GetAppointmentById(id);
            if (appointmentRes.IsFailure)
                return Problem(statusCode: 404, detail: appointmentRes.Error);

            return Ok(appointmentRes);
        }
        [HttpGet("free_dates")]
        public ActionResult<List<DomainLogic.Appointment>> GetFreeDates(int id)
        {
            if (id <= 0)
                return Problem(statusCode: 404, detail: "Неправильный id");
            var appointmentRes = _service.GetFreeDates(id);
            if (appointmentRes.IsFailure)
                return Problem(statusCode: 404, detail: appointmentRes.Error);

            return Ok(appointmentRes);
        }
    }
}
