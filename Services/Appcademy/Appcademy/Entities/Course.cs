using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Appcademy.Entities
{
  public class Course
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public List<StudentCourse> StudentCourses { get; set; }
  }
}
