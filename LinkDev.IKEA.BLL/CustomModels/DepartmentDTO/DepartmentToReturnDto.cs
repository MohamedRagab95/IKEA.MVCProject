using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkDev.IKEA.BLL.CustomModels.DepartmentDTO
{
    public class DepartmentToReturnDto
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }

        [Display (Name ="Date Of Creation")]
        public DateOnly CreationDate { get; set; }
    }
}
