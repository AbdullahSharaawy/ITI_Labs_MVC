using Sharaawy_BL.Services;
using Sharaawy_BL.ViewsModel.InstructorVM;
using Sharaawy_DAL.Enterfaces;
using Sharaawy_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

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
        public EditInstructor GetEditInstructorInfo(int id) {
            EditInstructor EditInstructer = new EditInstructor();
            EditInstructer.instructor = _ICRUD.GetByID(id);
            EditInstructer.departments = _DCRUD.GetAll();
            EditInstructer.courses = _CCRUD.GetAll();
            return EditInstructer;
        }
        public bool Update(EditInstructor EI)
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
        public bool Create(EditInstructor EI)
        {
            if (EI == null) 
            {
                return false;
            }
            if (EI.instructor.Name != null && EI.instructor.DeptId != null && EI.instructor.CrsId != null && EI.instructor.Image != null && EI.instructor.Address != null)
            {
                var instructor = new Instructor();
                instructor.Name = EI.instructor.Name;
                instructor.Image = EI.instructor.Image;
                instructor.Salary = EI.instructor.Salary;
                instructor.Address = EI.instructor.Address;
                instructor.DeptId = EI.instructor.DeptId;
                instructor.CrsId = EI.instructor.CrsId;
               
                _ICRUD.Create(instructor);
                return true;
            }
            return false ;
        }
    }
}
