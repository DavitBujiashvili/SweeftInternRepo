using CodeFirst.Data;
using CodeFirst.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CodeFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public TeacherController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("GetAllTeachersByStudent/{studentName}")]
        public ActionResult<Teacher[]> GetAllTeachersByStudent(string studentName)
        {
            var giorgisTeachers = from teacher in _context.Teachers.Include(x => x.Pupils)
                                  where teacher.Pupils.Any(p => p.FirstName == studentName)
                                  select teacher;

            return Ok(giorgisTeachers.ToArray());
        }
    }
}
