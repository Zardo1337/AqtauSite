using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AktauVoiceApi.Models;

namespace AktauVoiceApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ReportsController : ControllerBase
{
    private readonly AppDbContext _db;

    public ReportsController(AppDbContext db)
    {
        _db = db;
    }

    // Получить все обращения
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var reports = await _db.Reports.OrderByDescending(r => r.CreatedAt).ToListAsync();
        return Ok(reports);
    }

    // Создать новое обращение
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] Report report)
    {
        report.CreatedAt = DateTime.UtcNow;
        report.Status = "new";
        _db.Reports.Add(report);
        await _db.SaveChangesAsync();
        return Ok(report);
    }
}