using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SwabhimanHealthcareCMS.Data;

namespace SwabhimanHealthcareCMS.Controllers
{
    public class CardController : Controller
    {
        private readonly ApplicationDbContext _context;
        public CardController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var cards = _context.Cards
                .Include(x => x.Customer)
                .ToList();

            return View(cards);
        }
    }
}
