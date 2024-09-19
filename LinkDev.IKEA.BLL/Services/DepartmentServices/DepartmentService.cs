using LinkDev.IKEA.BLL.CustomModels.DepartmentDTO;
using LinkDev.IKEA.DAL.Enteties;
using LinkDev.IKEA.DAL.Enteties.Department;
using LinkDev.IKEA.DAL.Repositories.DepartmentRepo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkDev.IKEA.BLL.Services.DepartmentServices
{
    public class DepartmentService : IDepartmentServices
    {
        private readonly IDepartmentRepository _departmentRepository;

        public DepartmentService(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }


        public IEnumerable<DepartmentToReturnDto> GetAllDepartment()
        {
           var departments=_departmentRepository.GetAllDepartmentIQuarable().
                Select(department=> new DepartmentToReturnDto
                {
                    Name= department.Name,
                    Id= department.Id,
                    Code= department.Code,
                    CreationDate= department.CreationDate,
                }).AsNoTracking().ToList();

            return departments;
        }



        public DepartmentDetailsToReturnDto? GetDepartmentById(int id)
        {
            var dept =_departmentRepository.GetById(id);
           if (dept != null)
              return  new DepartmentDetailsToReturnDto()
              {
                    Name = dept.Name,
                    Id = dept.Id,
                    Code = dept.Code,
                    CreationDate = dept.CreationDate,
                    Description = dept.Description,
                    ModifiedBy=1,
                    ModifiedOn = DateTime.UtcNow,
                    

              };

           else return null;
            
        }



        public int CreateDepartment(CreatedDepartmentDto departmentDto)
        {
             var department = new Department()
             {
                 Name = departmentDto.Name,
                 Code = departmentDto.Code,
                 Description = departmentDto.Description,
                 ModifiedOn = DateTime.UtcNow,
             };

            return _departmentRepository.Add(department);
        }

        public int UpdateDepartment(UpdatedDepartmentDto departmentDto)
        {
            var department = new Department()
            {
                Name = departmentDto.Name,
                Code = departmentDto.Code,
                Description = departmentDto.Description,
                Id = departmentDto.Id,

            };
            return _departmentRepository.Update(department);
        }


        public bool DeleteDepartment(int id)
        {
            var department = _departmentRepository.GetById(id);

            if (department != null)
                return _departmentRepository.Delete(department) >0;

            else 
                return false;
        }


    }
}
