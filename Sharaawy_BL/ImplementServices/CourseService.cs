using Sharaawy_BL.Services;
using Sharaawy_DAL.DataBase;
using Sharaawy_DAL.Enterfaces;
using Sharaawy_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharaawy_BL.ImplementServices
{
    
    public class CourseService:ICourseService
    {
        private readonly ICRUD<Course> _CRUD;

        public CourseService(ICRUD<Course> cRUD)
        {
            _CRUD = cRUD;
        }

        public List<Course> GetAll()
        {
            return _CRUD.GetAll();
        }
    }
}
