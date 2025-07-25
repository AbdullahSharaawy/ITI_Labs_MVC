using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sharaawy_DAL.Entities;

public class Trainee
{
    [Key]
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Image { get; set; } = null!;

    public string Address { get; set; } = null!;
    [ForeignKey("DeptId")]
    public int? DeptId { get; set; }

    public decimal Grade { get; set; }

    public virtual ICollection<CrsResult> CrsResults { get; set; } = new List<CrsResult>();

    public virtual Department? Dept { get; set; }
}
