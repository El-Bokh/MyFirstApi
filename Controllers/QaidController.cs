using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyFirstApi.Data;
using MyFirstApi.Models;

namespace MyFirstApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class QaidController : ControllerBase
    {
        private readonly AppDbContext _context;

        public QaidController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var qaidList = await _context.Qaid.ToListAsync();
            return Ok(qaidList);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Qaid qaid)
        {
            _context.Qaid.Add(qaid);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetAll), new { id = qaid.QaidID }, qaid);
        }
    }
}
