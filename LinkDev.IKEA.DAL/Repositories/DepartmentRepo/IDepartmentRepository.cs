using LinkDev.IKEA.DAL.Enteties.Department;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkDev.IKEA.DAL.Repositories.DepartmentRepo
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> GetAll(bool WithAsNoTracking = true);

        IQueryable<Department> GetAllDepartmentIQuarable();
        Department? GetById(int id);

        int Update(Department entity);

        int  Delete(Department entity);

        int Add (Department entity);

    }
}
