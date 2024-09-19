using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkDev.IKEA.BLL.CustomModels.DepartmentDTO
{
    public class DepartmentDetailsToReturnDto
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        //[Display (Name= "Creation Date")]
        public DateOnly CreationDate { get; set; }

        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int ModifiedBy { get; set; }

     
    }
}
