using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace UniversityRegistrar.Models
{
  public class Course
  {
    public int CourseId { get; set; }
    [Required(ErrorMessage = "The course name can't be empty!")]
    public string Description { get; set; }
    public List<Student> Students { get; set; }
    public List<CourseStudent> JoinEntities { get; }
  }
}