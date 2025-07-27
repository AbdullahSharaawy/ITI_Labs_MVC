using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sharaawy_DAL.Entities;

public  class Instructor
{
    [Key]
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Image { get; set; } = null!;

    public decimal Salary { get; set; }

    public string Address { get; set; } = null!;
    [Display(Name = "Department")]
    [ForeignKey("DeptId")]
    public int? DeptId { get; set; }
    [Display(Name = "Course")]
    [ForeignKey("CrsId")]
    public int? CrsId { get; set; }

    public virtual Course? Crs { get; set; }

    public virtual Department? Dept { get; set; }

}
