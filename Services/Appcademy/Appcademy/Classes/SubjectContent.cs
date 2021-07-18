//using System.Collections.Generic;

//namespace Appcademy.Entities
//{
//  public class SubjectContent
//  {
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public List<SubjectParagraph> Paragraphs { get; set; }
//    public List<SubjectImage> Images { get; set; }
//    public List<SubjectVideo> Videos { get; set; }

//    public SubjectContent()
//    {
//    }

//  }

//  public class SubjectParagraph
//  {
//    public string Id { get; set; }
//    public string Text { get; set; }
//    public int Order { get; set; }
//  }

//  public class SubjectImage
//  {
//    public string Id { get; set; }
//    public string Path { get; set; }
//    public int Order { get; set; }
//  }

//  public class SubjectVideo
//  {
//    public string Id { get; set; }
//    public string Path { get; set; }
//    public int Order { get; set; }
//  }
//}

using System.Collections.Generic;
using System.Xml.Serialization;
  [XmlRoot(ElementName = "Paragraph")]
	public class Paragraph
	{
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
		[XmlAttribute(AttributeName = "order")]
		public string Order { get; set; }
	}

	[XmlRoot(ElementName = "Paragraphs")]
	public class Paragraphs
	{
		[XmlElement(ElementName = "Paragraph")]
		public List<Paragraph> Paragraph { get; set; }
	}

	[XmlRoot(ElementName = "Image")]
	public class Image
	{
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
		[XmlAttribute(AttributeName = "path")]
		public string Path { get; set; }
		[XmlAttribute(AttributeName = "oder")]
		public string Oder { get; set; }
	}

	[XmlRoot(ElementName = "Images")]
	public class Images
	{
		[XmlElement(ElementName = "Image")]
		public List<Image> Image { get; set; }
	}

	[XmlRoot(ElementName = "Video")]
	public class Video
	{
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
		[XmlAttribute(AttributeName = "path")]
		public string Path { get; set; }
		[XmlAttribute(AttributeName = "order")]
		public string Order { get; set; }
		[XmlAttribute(AttributeName = "type")]
		public string Type { get; set; }
	}

	[XmlRoot(ElementName = "Videos")]
	public class Videos
	{
		[XmlElement(ElementName = "Video")]
		public List<Video> Video { get; set; }
	}

	[XmlRoot(ElementName = "SubjectContent")]
	public class SubjectContent
	{
		[XmlElement(ElementName = "Paragraphs")]
		public Paragraphs Paragraphs { get; set; }
		[XmlElement(ElementName = "Images")]
		public Images Images { get; set; }
		[XmlElement(ElementName = "Videos")]
		public Videos Videos { get; set; }
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
		[XmlAttribute(AttributeName = "name")]
		public string Name { get; set; }
	}
