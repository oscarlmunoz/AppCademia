using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Appcademy.Context;
using Appcademy.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Appcademy.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class CourseController
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
    #endregion
  }
}
