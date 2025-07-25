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
    public class InstructorCRUD:ICRUD<Instructor>
    {
        private readonly SharaawyContext _context;
        public InstructorCRUD(SharaawyContext context)
        {
            _context = context;
        }

        public void Create(Instructor entity)
        {
           _context.Instructors.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(Instructor entity)
        {
            
            _context.Instructors.Remove(entity);
            _context.SaveChanges();
        }

        public List<Instructor > GetAll()
        {
            return _context.Instructors.ToList();
        }

        public Instructor GetByID(int id)
        {
            return _context.Instructors.FirstOrDefault(i => i.Id == id);
        }

        public void Update(Instructor entity)
        {
            _context.Instructors.Update(entity);
            _context.SaveChanges();
        }

        
    }
}
