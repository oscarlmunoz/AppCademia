using System;
namespace Appcademy.Entities
{
  public class Response
  {
    public int code { get; set; }
    public string status { get; set; }
    public object message { get; set; }

    public Response()
    {
      code = 400;
      status = "ok";
      message = new object();
    }
  }
}
