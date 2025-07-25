
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sharaawy_DAL.Entities;

public class Course
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Name { get; set; } = null!;
    [Range(50, 100)]
    [Required]
    public decimal Degree { get; set; }
    [Display(Name = "Minimum Degree")]
    [Range(20, 50)]
    [Required]
    // [Remote(action: "CheckMinDegree", controller: "CourseController", AdditionalFields = "Degree", ErrorMessage = "Minimum Degree must be less than Degree")]
    public decimal MinDegree { get; set; }
    [Display(Name = "Department ID")]
    [Required]
    [ForeignKey("Dept")]
    public int DeptId { get; set; }
    public virtual ICollection<CrsResult> CrsResults { get; set; } = new List<CrsResult>();
    public virtual Department? Dept { get; set; }

    public virtual ICollection<Instructor> Instructors { get; set; } = new List<Instructor>();
}
