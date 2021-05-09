using System;
using Newtonsoft.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using JsonIgnoreAttribute = Newtonsoft.Json.JsonIgnoreAttribute;

namespace Appcademy.Entities
{
  public class StudentCourse
  {

      public int StudentId { get; set; }
      public int CourseId { get; set; }
      public Student Student { get; set; }
      public Course Course { get; set; }
  }
}
