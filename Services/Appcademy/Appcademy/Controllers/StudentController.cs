using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Appcademy.Context;
using Appcademy.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Appcademy.Controllers
{

  [Route("api/[controller]")]
  [ApiController]
  public class StudentController : Controller
  {
    #region context injection
      private readonly ApplicationDbContext context;

      public StudentController(ApplicationDbContext context)
      {
        this.context = context;
      }
    #endregion

    #region methods
      [HttpGet]
      public async Task<ActionResult<IEnumerable<Student>>> Get()
      {
        return await context.Students.ToListAsync();
      }

      [HttpGet("{id}", Name = "GetUser")]
      public ActionResult<List<StudentCourse>> Get(int id)
      {

      var studentCourse = context.StudentCourses
          .Include(x => x.Student)
          .Include(x=> x.Course)
          .Where(x => x.StudentId == id)
          .ToList();

        if (studentCourse == null)
        {
          return NotFound();
        }

      return studentCourse;
      }


      [HttpPost("register")]
      public async Task<ActionResult> Register([FromBody] Student user)
      {
        await context.Students.AddAsync(user);
        await context.SaveChangesAsync();
        return new CreatedAtRouteResult("ObtenerUsusario", new { id = user.Id }, user);
      }

      [HttpPost("login")]
      public async Task<ActionResult> Login([FromBody] Student user)
      {
        Response res = new Response();
        Student findUser = await context.Students.FirstOrDefaultAsync(x => x.Email == user.Email && x.Password == user.Password);
        if (findUser == null)
        {
          res.Code = 1000;
          res.Status = "ko";
          return NotFound();
        }
      findUser.Token = "MockTokenOk";
      res.Message = findUser;
        return Ok(res);
      }

      [HttpPut("{id}")]
      public async Task<ActionResult> Put(int id, [FromBody] Student value)
      {
        if (id != value.Id)
        {
          return BadRequest();
        }

        context.Entry(value).State = EntityState.Modified;
        await context.SaveChangesAsync();
        return Ok();
      }

      [HttpDelete("{id}")]
      public async Task<ActionResult<Student>> Delete(int id)
      {
        var user = await context.Students.FirstOrDefaultAsync(x => x.Id == id);

        if (user == null)
        {
          return NotFound();
        }

        context.Students.Remove(user);
        await context.SaveChangesAsync();
        return user;
      }

      [HttpPost("enroll")]
      public async Task<ActionResult> Enroll([FromBody] int studentId, int courseId)
      {
      //Todo validate if student and course exists
      var student = await context.Students.FirstOrDefaultAsync(x => x.Id == studentId);
      var course = await context.Courses.FirstOrDefaultAsync(x => x.Id == courseId);
      if (student == null || course == null)
      {
        return NotFound();
      }

      var studentCourse = new StudentCourse();
      studentCourse.StudentId = student.Id;
      studentCourse.CourseId = course.Id;

      await context.StudentCourses.AddAsync(studentCourse);
      await context.SaveChangesAsync();

      return new CreatedAtRouteResult("ObtenerUsusario", new { id = student.Id }, student);
    }
    #endregion
  }

}
