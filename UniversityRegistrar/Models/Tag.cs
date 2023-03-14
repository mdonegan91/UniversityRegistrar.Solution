using System.Collections.Generic;

namespace UniversityRegistrar.Models
{
  public class Tag
  {
    public int TagId { get; set; }
    public string Title { get; set; }
    public List<StudentTag> JoinEntities { get;}
  }
}