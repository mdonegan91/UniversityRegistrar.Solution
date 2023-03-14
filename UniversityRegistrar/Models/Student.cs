using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UniversityRegistrar.Models
{
  public class Student
  {
    public int StudentId { get; set; }
    [Required(ErrorMessage = "The students's name can't be empty!")]
    public string Name { get; set; }
    [Range(1, int.MaxValue, ErrorMessage = "You must add your student to a course. Have you created a course yet?")]
    public int CourseId { get; set; }
    public Course Course { get; set; }
    public List<StudentTag> JoinEntities { get;}
    public List<CourseStudent> JoinEntities2 { get; }
  }
}
