using DomainLogic.Services;
using DocInfo.Views;
using Microsoft.AspNetCore.Mvc;
using Models;
using DomainLogic;

namespace DocInfo.Controllers
{
    public class ScheduleController : ControllerBase
    {
        ScheduleService _service;
        ScheduleController(ScheduleService service)
        {
            _service = service;
        }
        [HttpGet("get_schedule")]
        public ActionResult<DomainLogic.Schedule> GetSchedule(int doctor_id, DateOnly date)
        {
            if (doctor_id <= 0)
                return Problem(statusCode: 404, detail: "Неправильный id");
            if (date < DateOnly.FromDateTime(DateTime.Now))
                return Problem(statusCode: 404, detail: "Неверная дата");
            var scheduleRes = _service.GetSchedule(doctor_id, date);
            if (scheduleRes.IsFailure)
                return Problem(statusCode: 404, detail: scheduleRes.Error);

            return Ok(scheduleRes);
        }
        [HttpGet("add_schedule")]
        public ActionResult<DomainLogic.Schedule> AddSchedule(ScheduleModel schedule)
        {
            if (schedule.id <= 0 || schedule?.doctor_id == null || schedule?.date == null)
                return Problem(statusCode: 404, detail: "Не указаны все данные");
            var scheduleRes = _service.AddSchedule(schedule);
            if (scheduleRes.IsFailure)
                return Problem(statusCode: 404, detail: scheduleRes.Error);

            return Ok(scheduleRes);
        }
    }
}
