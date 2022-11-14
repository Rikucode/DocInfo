using DomainLogic;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public static class DoctorModelToDomain
    {
        public static Doctor? ToDomain(this DoctorModel model)
        {
            return new Doctor
            {
                id = model.id,
                name = model.name,
                speciality_id = model.speciality_id
            };
        }
        public static IEnumerable<Doctor>? ToDomain(this List<DoctorModel> model)
        {
            List<Doctor>? result = new List<Doctor>();
            foreach (DoctorModel dm in model)
            {
                result.Add(dm.ToDomain());
            }
            return result;
        }
    }
}
