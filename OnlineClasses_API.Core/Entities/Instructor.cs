using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OnlineClasses_API.Core.Entities;

[Table("Instructor")]
public partial class Instructor
{
    [Key]
    public int InstructorId { get; set; }

    [StringLength(50)]
    public string FirstName { get; set; } = null!;

    [StringLength(50)]
    public string LastName { get; set; } = null!;

    [StringLength(100)]
    public string Email { get; set; } = null!;

    public string? Bio { get; set; }

    public int UserId { get; set; }

    [InverseProperty("Instructor")]
    public virtual ICollection<CourseModel> Courses { get; set; } = new List<CourseModel>();

    [ForeignKey("UserId")]
    [InverseProperty("Instructors")]
    public virtual UserProfile User { get; set; } = null!;
}
