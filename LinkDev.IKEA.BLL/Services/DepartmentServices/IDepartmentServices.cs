using LinkDev.IKEA.BLL.CustomModels.DepartmentDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkDev.IKEA.BLL.Services.DepartmentServices
{
    public interface IDepartmentServices
    {
        IEnumerable<DepartmentToReturnDto> GetAllDepartment();

        DepartmentDetailsToReturnDto? GetDepartmentById(int id);

        int CreateDepartment(CreatedDepartmentDto departmentDto);

        int UpdateDepartment (UpdatedDepartmentDto departmentDto);

        bool DeleteDepartment(int id);

    }
}
