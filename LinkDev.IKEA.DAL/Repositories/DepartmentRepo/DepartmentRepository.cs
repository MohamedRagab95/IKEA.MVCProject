using LinkDev.IKEA.DAL.Data;
using LinkDev.IKEA.DAL.Enteties.Department;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkDev.IKEA.DAL.Repositories.DepartmentRepo
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public DepartmentRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }




        public IEnumerable<Department> GetAll(bool WithAsNoTracking = true )
        {
            if (WithAsNoTracking) 
            return _applicationDbContext.Departments.AsNoTracking().ToList();

            else
            return _applicationDbContext.Departments.ToList();
        }

        public Department? GetById(int id)
        {
            return _applicationDbContext.Departments.Find(id);
        }

        public int Add(Department entity)
        {
                _applicationDbContext.Departments.Add(entity);
           return _applicationDbContext.SaveChanges();
        }

        public int Update(Department entity)
        {
            _applicationDbContext.Departments.Update(entity);
            return _applicationDbContext.SaveChanges();
        }


        public int Delete(Department entity)
        {
            _applicationDbContext.Departments.Remove(entity);
            return _applicationDbContext.SaveChanges();
        }

        public IQueryable<Department> GetAllDepartmentIQuarable()
        {
            return _applicationDbContext.Departments;
        }
    }

}
