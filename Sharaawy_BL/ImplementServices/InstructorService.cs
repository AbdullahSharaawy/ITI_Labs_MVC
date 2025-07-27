using Sharaawy_BL.Services;
using Sharaawy_BL.DTO;
using Sharaawy_DAL.Enterfaces;
using Sharaawy_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Sharaawy_BL.Helper;
using System.Collections;

namespace Sharaawy_BL.ImplementServices
{
    public class InstructorService : IInstructorService
    {
        private readonly ICRUD<Instructor> _ICRUD;
        private readonly ICRUD<Department> _DCRUD;
        private readonly ICRUD<Course> _CCRUD;
        public InstructorService(ICRUD<Instructor> iCRUD, ICRUD<Department> dCRUD, ICRUD<Course> cCRUD)
        {
            _ICRUD = iCRUD;
            _DCRUD = dCRUD;
            _CCRUD = cCRUD;
        }

        public List<Instructor> GetAll()
        {
			return _ICRUD.GetAll();
        }
        public InstructorDTO GetEditInstructorInfo(int id) {
            InstructorDTO EditInstructer = new InstructorDTO();
            EditInstructer.instructor = _ICRUD.GetByID(id);
            EditInstructer.departments = _DCRUD.GetAll();
            EditInstructer.courses = _CCRUD.GetAll();
            return EditInstructer;
        }
        public bool Update(InstructorDTO EI)
        {
            if(EI==null)
                return false;

            var instructor = this._ICRUD.GetByID(EI.instructor.Id);
            if (instructor != null && EI.instructor.Name != null && EI.instructor.DeptId != null && EI.instructor.CrsId != null && EI.instructor.Image != null && EI.instructor.Address != null)
            {
                    instructor.Name = EI.instructor.Name;
                    instructor.Image = EI.instructor.Image;
                    instructor.Salary = EI.instructor.Salary;
                    instructor.Address = EI.instructor.Address;
                    instructor.DeptId = EI.instructor.DeptId;
                    instructor.CrsId = EI.instructor.CrsId;
                    _ICRUD.Update(instructor);
                    return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            var ins = _ICRUD.GetByID(id);
            if (ins != null) { 
               _ICRUD.Delete(ins);
            }
            return false;
        }
        public bool Create(InstructorDTO EI)
        {
            if (EI == null) 
            {
                return false;
            }
            if (EI.instructor.Name != null && EI.instructor.DeptId != null && EI.instructor.CrsId != null  && EI.instructor.Address != null)
            {
                var instructor = new Instructor();
                instructor.Name = EI.instructor.Name;
               
                instructor.Salary = EI.instructor.Salary;
                instructor.Address = EI.instructor.Address;
                instructor.DeptId = EI.instructor.DeptId;
                instructor.CrsId = EI.instructor.CrsId;
                instructor.Image = Upload.UploadFile("Files", EI.file);

                _ICRUD.Create(instructor);
                return true;
            }
            return false ;
        }

		public List<InstructorDetailsDTO> GetInstructorInfo(int id)
		{
            
			Instructor ins=_ICRUD.GetByID(id);
            List<Course> courses = _CCRUD.GetAll().Where(c=>c.Id==ins.CrsId).ToList();
            List<Department> departments=_DCRUD.GetAll().Where(d=>d.Id==ins.DeptId).ToList();
            List<InstructorDetailsDTO> instructorDetailsDTOs = new List<InstructorDetailsDTO>();
            instructorDetailsDTOs = (from course in courses
                                     join department in departments
                                     on course.DeptId equals department.Id
                                     select new InstructorDetailsDTO
                                     {
                                         CourseName = course.Name,
                                         DepartmentName = department.Name
                                         // Map other properties here
                                     }).ToList();
         return instructorDetailsDTOs;
        }

        
    }
}
