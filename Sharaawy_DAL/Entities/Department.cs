using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Sharaawy_DAL.Entities;

public  class Department
{
    [Key]
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Manager { get; set; } = null!;

    public virtual ICollection<Course> Courses { get; set; } = new List<Course>();

    public virtual ICollection<Instructor> Instructors { get; set; } = new List<Instructor>();

    public virtual ICollection<Trainee> Trainees { get; set; } = new List<Trainee>();
}
