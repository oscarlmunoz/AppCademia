using System;
using System.Collections.Generic;
using Appcademy.Entities;
using Appcademy.Interfaces;

namespace Appcademy.Lib
{
  public class FileLib : IFileLib
  {

    public List<CourseContent> ReadCourseContent(string fileName)
    {
      List<CourseContent> syllabus = new List<CourseContent>();
      string filePath = "CourseContent/";
      string csvData = System.IO.File.ReadAllText(filePath + fileName);
      foreach (string row in csvData.Split('\n'))
      {
        if (!string.IsNullOrEmpty(row))
        {
          syllabus.Add(new CourseContent
          {
            Id = Convert.ToInt32(row.Split(';')[0]),
            Name = row.Split(';')[1],
            Image = row.Split(';')[2],
            Text = row.Split(';')[3],
            Video = row.Split(';')[4]
          });
        }
      }
      return syllabus;
    }

  }
}
