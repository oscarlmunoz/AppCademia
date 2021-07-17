namespace Appcademy.Entities
{
  public class Response
  {
    public int Code { get; set; }
    public string Status { get; set; }
    public object Message { get; set; }

    public Response()
    {
      Code = 400;
      Status = "ok";
      Message = new object();
    }
  }
}
