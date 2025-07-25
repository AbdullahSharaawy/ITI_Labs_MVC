using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sharaawy_BL.ViewsModel.InstructorVM;
using Sharaawy_DAL;
using Sharaawy_DAL.Enterfaces;
using Sharaawy_DAL.Entities;
using Sharaawy_DAL.ImplementInterfaces;
namespace Sharaawy_BL.Services
{
    public interface IInstructorService
    {

        public List<Instructor> GetAll();
        public bool Update(EditInstructor instructor);
        public bool Delete(int id);
        public bool Create(EditInstructor instructor);
        public EditInstructor GetEditInstructorInfo(int id);
    }
}
