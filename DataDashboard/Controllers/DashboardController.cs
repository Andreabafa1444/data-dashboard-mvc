using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DataDashboard.Models;
using DataDashboard.Data;

namespace DataDashboard.Controllers
{
    [ApiController]
    [Route("api/students")]
    public class DashboardController : Controller
    {
        // inyeccion 
        private readonly AppDbContext _context;
        public DashboardController(AppDbContext context)
        {
            _context = context;
        }
        //Sacar datos reales vía API y mostrarlos en una vista MVC.
        [HttpGet]
        public IActionResult GetStudents()
        {
            var students = _context.StudentSocialMedias
                .Take(20)
                .ToList();
            return Ok(students);
        }
        //aqui comenzamos con el primer filtrado que es oara country, academyclevel y mmostused plataform
        [HttpGet]
        public IActionResult FilterStudents(
            string? country,
            string? academicLevel,
            string? platform
        )
        {
                var query = _context.StudentSocialMedias.AsQueryable();

            if (!string.IsNullOrEmpty(country))
                query = query.Where(s => s.Country == country);

            if (!string.IsNullOrEmpty(academicLevel))
                query = query.Where(s => s.AcademicLevel == academicLevel);

            if (!string.IsNullOrEmpty(platform))
                query = query.Where(s => s.MostUsedPlatform == platform);

            return Ok(query.Take(50).ToList());

        }
            [HttpGet("metrics")]
            public IActionResult GetMetrics()
            {
                return Ok(new
                {
                    totalStudents = _context.StudentSocialMedias.Count(),
                    avgUsage = _context.StudentSocialMedias.Average(s => s.AvgDailyUsageHours),
                    avgSleep = _context.StudentSocialMedias.Average(s => s.SleepHoursPerNight),
                    avgAddiction = _context.StudentSocialMedias.Average(s => s.AddictionScore)
                });
            }
    }

}