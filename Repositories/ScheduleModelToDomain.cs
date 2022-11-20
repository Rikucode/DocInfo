using DomainLogic;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public static class ScheduleModelToDomain
    {
        public static Schedule? ToDomain(this ScheduleModel model)
        {
            return new Schedule
            {
                id = model.id,
                doctorId = model.doctor_id,
                date = model.date,
                workdayStart = model.workdayStart,
                workdayEnd = model.workdayEnd
            };
        }
        public static IEnumerable<Schedule>? ToDomain(this List<ScheduleModel> model)
        {
            List<Schedule>? result = new List<Schedule>();
            foreach (ScheduleModel am in model)
            {
                result.Add(am.ToDomain());
            }
            return result;
        }
    }
}
