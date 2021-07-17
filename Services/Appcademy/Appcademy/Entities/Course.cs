using System.Collections.Generic;

namespace Appcademy.Entities
{
  public class Course
  {
    public int Id { get; set; }
    public string Code { get; set; }
    public string Name { get; set; }
    public string Image { get; set; }
    public string Title { get; set; }
    public string Subtitle { get; set; }
    public string Description { get; set; }
    public string Syllabus { get; set; }
    public List<StudentCourse> StudentCourses { get; set; }
  }
}
