using Sharaawy_BL.Services;
using Sharaawy_DAL.Enterfaces;
using Sharaawy_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sharaawy_BL.DTO;
using Sharaawy_BL.Mapperly;
namespace Sharaawy_BL.ImplementServices
{
   public class DepartmentService:IDepartmentService
    {
        private readonly ICRUD<Department> _CRUD;

        public DepartmentService(ICRUD<Department> CRUD)
        {
            _CRUD = CRUD;
        }

        public List<Department> GetAll()
        {
            return _CRUD.GetAll();
        }
        public List<DepartmentDTO> ViewDepartments()
        {
            var Dep = GetAll();
            var mapping = new DepartmentMapper();
            List<DepartmentDTO> departmetnsDTO=mapping.MapToDepartmentDTOList(Dep);
            return departmetnsDTO;
        }
    }
}
