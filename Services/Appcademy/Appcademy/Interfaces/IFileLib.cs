using System;
using System.Collections.Generic;
using Appcademy.Entities;

namespace Appcademy.Interfaces
{
  public interface IFileLib
  {
    List<CourseContent> ReadFile(string fileName);
  }
}
