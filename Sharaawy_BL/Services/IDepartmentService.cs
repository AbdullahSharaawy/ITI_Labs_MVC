﻿using Sharaawy_BL.DTO;
using Sharaawy_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharaawy_BL.Services
{
    public interface IDepartmentService
    {
        public List<Department> GetAll();
        public List<DepartmentDTO> ViewDepartments();
        public Department ViewDepartment(int ID);
    }
}
