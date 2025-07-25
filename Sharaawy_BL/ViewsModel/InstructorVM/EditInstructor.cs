using Sharaawy_DAL.Entities;

namespace Sharaawy_BL.ViewsModel.InstructorVM
{
    public class EditInstructor
    {
        public Instructor instructor { get; set; }
        public List<Department> departments { get; set; }
        public List<Course> courses { get; set; }
    }
}
