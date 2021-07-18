using System.Collections.Generic;
using Appcademy.Entities;

namespace Appcademy.Interfaces
{
  public interface ICourseLib
  {
    public List<CourseContent> GetCourseContent(string fileName);
    public SubjectContent GetSubjectContent(string fileName);
  }
}
