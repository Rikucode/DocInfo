﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLogic.Models
{
    public class Doctor
    {
        public int id { get; set; }
        string name { get; set; }

        Speciality speciality;
    }
}
