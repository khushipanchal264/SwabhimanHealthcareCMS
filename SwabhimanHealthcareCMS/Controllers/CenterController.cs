using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SwabhimanHealthcareCMS.Data;
using SwabhimanHealthcareCMS.Models;

namespace SwabhimanHealthcareCMS.Controllers
{
    public class CenterController : Controller
    {
        private readonly ApplicationDbContext _context;
        public CenterController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(
                await _context.Centers.ToListAsync()
            );
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(
    Center center)
        {
            if (ModelState.IsValid)
            {
                _context.Add(center);

                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            return View(center);
        }
    }
}
