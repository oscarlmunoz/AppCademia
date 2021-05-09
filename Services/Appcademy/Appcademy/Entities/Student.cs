using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Appcademy.Entities
{
  public class Student
  {
    public int Id { get; set; }
    public string Name { get; set; }
    [Required]
    public string Email { get; set; }
    [Required]
    public string Password { get; set; }
    public bool Admin { get; set; } //TODO (Just for educational purposes) - Create JWT Security Auth
    public string Token { get; set; }
    public List<StudentCourse> StudentCourses { get; set; }
  }
}
