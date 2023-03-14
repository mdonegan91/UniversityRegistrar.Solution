namespace UniversityRegistrar.Models
{
  public class StudentTag
    {       
        public int StudentTagId { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int TagId { get; set; }
        public Tag Tag { get; set; }
    }
}