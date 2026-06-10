using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SwabhimanHealthcareCMS.Data;
using SwabhimanHealthcareCMS.Models;

namespace SwabhimanHealthcareCMS.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ApplicationDbContext _context;
        public CustomerController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var customers = _context.Customers.ToList();
            return View(customers);
        }
        public IActionResult Create()
        {

            ViewBag.Centers = _context.Centers.ToList();
            return View();
        }
        [HttpPost]
       public IActionResult Create(Customer customer)
{
    if (!ModelState.IsValid)
    {
        foreach (var error in ModelState.Values.SelectMany(v => v.Errors))
        {
            Console.WriteLine(error.ErrorMessage);
        }

        ViewBag.Centers = _context.Centers.ToList();
        return View(customer);
    }

    customer.CreatedAt = DateTime.Now;
    customer.Status = "Active";

    _context.Customers.Add(customer);
    _context.SaveChanges();

    return RedirectToAction("Index");
}
        public IActionResult Details(int id)
        {
            var customer = _context.Customers.Find(id);

            if (customer == null)
                return NotFound();

            return View(customer);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var customer = await _context.Customers.FindAsync(id);

            if (customer == null)
                return NotFound();

            return View(customer);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, Customer customer)
        {
            if (id != customer.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                _context.Update(customer);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            return View(customer);
        }
        public async Task<IActionResult> Delete(int id)
        {
            var customer = await _context.Customers
                .FirstOrDefaultAsync(x => x.Id == id);

            if (customer == null)
                return NotFound();

            return View(customer);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var customer = await _context.Customers.FindAsync(id);

            _context.Customers.Remove(customer);

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}
