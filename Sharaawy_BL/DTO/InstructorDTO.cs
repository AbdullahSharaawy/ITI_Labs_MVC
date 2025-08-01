﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using Sharaawy_DAL.Entities;

namespace Sharaawy_BL.DTO
{
    public class InstructorDTO
    {
        public Instructor instructor { get; set; }
        public List<Department> departments { get; set; }
        public List<Course> courses { get; set; }
        public IFormFile file { get; set; }
    }
}