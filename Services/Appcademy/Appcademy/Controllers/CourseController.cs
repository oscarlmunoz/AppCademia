using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Appcademy.Context;
using Appcademy.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Appcademy.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class CourseController : Controller
  {
    #region context injection
    private readonly ApplicationDbContext context;

    public CourseController(ApplicationDbContext context)
    {
      this.context = context;
    }
    #endregion

    #region methods
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Course>>> Get()
    {
      return await context.Courses.ToListAsync();
    }

    [HttpGet("{code}", Name = "ObtenerCursoByCode")]
    public ActionResult<Course> Get(string code)
    {

      var course = context.Courses
        .SingleOrDefault(e => e.Code == code);

      if (course == null)
      {
        return NotFound();
      }

      return course;
    }


    [HttpPost("register")]
    public async Task<ActionResult> Register([FromBody] Course course)
    {
      await context.Courses.AddAsync(course);
      await context.SaveChangesAsync();
      return new CreatedAtRouteResult("ObtenerUsusario", new { id = course.Id }, course);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult> Put(int id, [FromBody] Course course)
    {
      if (id != course.Id)
      {
        return BadRequest();
      }

      context.Entry(course).State = EntityState.Modified;
      await context.SaveChangesAsync();
      return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<Course>> Delete(int id)
    {
      var course = await context.Courses.FirstOrDefaultAsync(x => x.Id == id);

      if (course == null)
      {
        return NotFound();
      }

      context.Courses.Remove(course);
      await context.SaveChangesAsync();
      return course;
    }
    #endregion
  }
}
