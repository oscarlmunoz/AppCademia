using System.Collections.Generic;

namespace Appcademy.Entities
{
  public class SubjectContent
  {
    public int Id { get; set; }
    public List<SubjectParagraph> Paragraphs { get; set; }
    public List<SubjectImage> Images { get; set; }
    public List<SubjectVideo> Videos { get; set; }

    public SubjectContent()
    {
    }

  }

  public class SubjectParagraph
  {
    public string Id { get; set; }
    public string Text { get; set; }
    public int Order { get; set; }
  }

  public class SubjectImage
  {
    public string Id { get; set; }
    public string Path { get; set; }
  }

  public class SubjectVideo
  {
    public string Id { get; set; }
    public string Path { get; set; }
  }
}
