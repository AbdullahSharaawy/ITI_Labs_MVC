using Sharaawy_DAL.DataBase;
using Sharaawy_DAL.Enterfaces;
using Sharaawy_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharaawy_DAL.ImplementInterfaces
{
    public class DepartmentCRUD : ICRUD<Department>
    {
        private readonly SharaawyContext _context;

        public DepartmentCRUD(SharaawyContext context)
        {
            _context = context;
        }

        public void Create(Department entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Department entity)
        {
            throw new NotImplementedException();
        }

        public List<Department> GetAll()
        {
           return _context.Departments.ToList();
        }

        public Department GetByID(int id)
        {
            return _context.Departments.FirstOrDefault(i => i.Id == id);
        }

        public void Update(Department entity)
        {
            throw new NotImplementedException();
        }
    }
}
