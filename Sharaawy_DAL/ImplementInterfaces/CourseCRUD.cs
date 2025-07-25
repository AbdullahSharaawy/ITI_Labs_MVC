using Sharaawy_DAL.Enterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sharaawy_DAL.Entities;
using Sharaawy_DAL.DataBase;
namespace Sharaawy_DAL.ImplementInterfaces
{
   public class CourseCRUD : ICRUD<Course>
    {
        private readonly SharaawyContext _context;

        public CourseCRUD(SharaawyContext context)
        {
            _context = context;
        }

        public void Create(Course entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Course entity)
        {
            throw new NotImplementedException();
        }

        public List<Course> GetAll()
        {
            return _context.Courses.ToList();
        }

        public Course GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Course entity)
        {
            throw new NotImplementedException();
        }
    }
}
