using System;
using System.Collections.Generic;
using Appcademy.Entities;

namespace Appcademy.Interfaces
{
  public interface IFileLib
  {
    string ReadCsvFileContent(string fileName, string path);
  }
}
