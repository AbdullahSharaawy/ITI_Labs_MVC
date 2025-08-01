﻿using Microsoft.AspNetCore.Mvc;
using Sharaawy_DAL.DataBase;
using Sharaawy_DAL.Entities;
using Sharaawy_BL.Services;
using Sharaawy_BL.DTO;

using System.Net;
using Microsoft.CodeAnalysis.Scripting;
namespace Sharaawy.Controllers
{
    public class InstructorController : Controller
    {
        private readonly IInstructorService _IS;
        private readonly IDepartmentService _DS;
        private readonly ICourseService _CS;
        public InstructorController(IInstructorService iS, IDepartmentService dS, ICourseService cS)
        {
            _IS = iS;
            _DS = dS;
            _CS = cS;
        }

        public IActionResult Index()
        {
            return View("Instructors",_IS.GetAll() );
        }
        
        
        public IActionResult DeleteInstructor(int id)
        {
            _IS.Delete(id);
            return View("Instructors", _IS.GetAll());
        }

        [HttpGet]
        public IActionResult UpdateInstructor(int id)
        {
           
            return View("UpdateInstructor", _IS.GetEditInstructorInfo(id));
        }
        [HttpPost]
        public IActionResult SaveEdit(InstructorDTO EI)
        {
            
                if(_IS.Update(EI))
                {
                    return RedirectToAction("Index");
                }
                else
            {
                EI.departments = _DS.GetAll();
                EI.courses = _CS.GetAll();
                return View("UpdateInstructor", EI);
            }
            
        }
        [HttpGet]
        public IActionResult NewInstructor(InstructorDTO NI)
        {
            NI.departments = _DS.GetAll();
            NI.courses = _CS.GetAll();
            return View("NewInstructor", NI);
        }
        [HttpPost]
        public IActionResult AddNewInstructor(InstructorDTO NI)
        {

           
                if(_IS.Create(NI))
                {
                return RedirectToAction("Index");
            }
           else
            {
                NI.departments = _DS.GetAll();
                NI.courses = _CS.GetAll();
                return View("NewInstructor", NI);

            }
        }
        public IActionResult InstructorDetails(int id)
        {
            return Json(_IS.GetInstructorInfo(id));
        }
        public IActionResult Courses(int DeptID)
        {
            return Json(_CS.GetAll().Where(c => c.DeptId == DeptID).Select(c=>new {Id=c.Id,Name=c.Name}).ToList());
        }
    }
}

