using DomainLogic.Services;
using DocInfo.Views;
using Microsoft.AspNetCore.Mvc;
using Models;
using DomainLogic;


namespace DocInfo.Controllers
{
    public class DoctorController : ControllerBase
    {
        private readonly DoctorService _service;
        public DoctorController(DoctorService service)
        {
            _service = service;
        }
        [HttpGet("add_doctor")]
        public ActionResult<DomainLogic.Doctor> AddDoctor(DoctorModel doctor)
        {
            if (doctor.name == string.Empty || doctor?.speciality_id == null)
                return Problem(statusCode: 404, detail: "Не указано имя или специальность");
            var doctorRes = _service.AddDoctor(doctor);
            if (doctorRes.IsFailure)
                return Problem(statusCode: 404, detail: doctorRes.Error);

            return Ok(doctorRes);
        }
        [HttpGet("doctor_list")]
        public ActionResult<List<DoctorView>> GetAllDoctors()
        {
            var doctorRes = _service.GetAllDoctors();
            if (doctorRes.IsFailure)
                return Problem(statusCode: 404, detail: doctorRes.Error);

            return Ok(doctorRes);
        }
        [HttpGet("doctor_by_id")]
        public ActionResult<DoctorView> GetDoctorById(int id)
        {

            if (id <= 0)
                return Problem(statusCode: 404, detail: "Неправильный id");
            var doctorRes = _service.GetDoctorById(id);
            if (doctorRes.IsFailure)
                return Problem(statusCode: 404, detail: doctorRes.Error);

            return Ok(doctorRes);
        }
        [HttpGet("doctor_by_speciality")]
        public ActionResult<List<DoctorView>> GetDoctorsBySpeciality(int speciality_id)
        {

            if (speciality_id <= 0)
                return Problem(statusCode: 404, detail: "Неправильный id");
            var doctorRes = _service.GetDoctorsBySpeciality(speciality_id);
            if (doctorRes.IsFailure)
                return Problem(statusCode: 404, detail: doctorRes.Error);

            return Ok(doctorRes);
        }
    }
}
