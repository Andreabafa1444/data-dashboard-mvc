using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Json;
using DataDashboard.Models;
using DataDashboard.Data;
using Microsoft.Extensions.Http;

namespace DataDashboard.Controllers
{
    public class DataDashboardController : Controller
    {
        //aqui IHttpClientFactory es una interfaz que viene ya de ASP.net nos permite crear uyn HttpClient de forma segura y reutilizable
        private readonly HttpClient _httpClient;
        public DataDashboardController(IHttpClientFactory httpClientFactory)       
         {
             _httpClient = httpClientFactory.CreateClient();
        }
        public async Task<IActionResult> Index(
    string? country,
    string? academicLevel,
    string? platform
)
{
    var url = $"http://localhost:5124/api/students/filter" +
              $"?country={country}&academicLevel={academicLevel}&platform={platform}";

    var students = await _httpClient
        .GetFromJsonAsync<List<StudentSocialMedia>>(url);

    // 🔹 opciones únicas para dropdowns
    ViewBag.Countries = students
        .Select(s => s.Country)
        .Distinct()
        .OrderBy(c => c)
        .ToList();

    ViewBag.AcademicLevels = students
        .Select(s => s.AcademicLevel)
        .Distinct()
        .OrderBy(a => a)
        .ToList();

    ViewBag.Platforms = students
        .Select(s => s.MostUsedPlatform)
        .Distinct()
        .OrderBy(p => p)
        .ToList();

    return View(students);
}

    }
}