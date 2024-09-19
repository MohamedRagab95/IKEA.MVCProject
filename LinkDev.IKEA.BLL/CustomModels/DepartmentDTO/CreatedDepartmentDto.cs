﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkDev.IKEA.BLL.CustomModels.DepartmentDTO
{
    public class CreatedDepartmentDto
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateOnly CreationDate { get; set; }
    }
}
