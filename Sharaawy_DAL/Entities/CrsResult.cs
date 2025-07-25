using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sharaawy_DAL.Entities;

public  class CrsResult
{
    [Key]
    public int Id { get; set; }

    public int Degree { get; set; }
    [ForeignKey("CrsId")]
    public int? CrsId { get; set; }
    [ForeignKey("TraineeId")]
    public int? TraineeId { get; set; }

    public virtual Course? Crs { get; set; }

    public virtual Trainee? Trainee { get; set; }
}
