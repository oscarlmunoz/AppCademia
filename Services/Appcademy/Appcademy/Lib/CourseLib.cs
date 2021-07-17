using System;
using System.Collections.Generic;
using Appcademy.Entities;
using Appcademy.Interfaces;

namespace Appcademy.Lib
{
  public class CourseLib : ICourseLib
  {
    private readonly IFileLib _fileLib;

    public CourseLib(IFileLib fileLib)
    {
      this._fileLib = fileLib;

    }

    public List<CourseContent> GetCourseContent(string fileName)
    {
      List<CourseContent> syllabus = new List<CourseContent>();
      string csvData = _fileLib.ReadCsvFileContent(fileName, "CourseContent/"); //TODO pasar a variable de contexto
      if (!string.IsNullOrEmpty(csvData))
      {
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
      }
      return syllabus;
    }

    public SubjectContent GetSubjectContent(string fileName, string path)
    {
      SubjectContent syllabus = new SubjectContent();
      string csvData = _fileLib.ReadCsvFileContent(fileName, path); // TODO esto realmente llamará a otra función que obtenga un xml
      if (!string.IsNullOrEmpty(csvData))
      {
        //TODO Implementar lógica para obtener datos de XML
      }
      return syllabus;
    }

  }
}
