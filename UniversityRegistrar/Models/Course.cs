
using System.Collections.Generic;

namespace UniversityRegistrar.Models
{
  public class Course
  {
    public int CourseId { get; set; }
    public string Description { get; set; }
    public List<Student> Students { get; set; }
  }
}