using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SwabhimanHealthcareCMS.Data;
using SwabhimanHealthcareCMS.Models;

namespace SwabhimanHealthcareCMS.Controllers
{
    public class CustomerController : Controller
    {
        //private readonly ApplicationDbContext _context;
        //public CustomerController(ApplicationDbContext context)
        //{
        //    _context = context;
        //}
        public IActionResult Index()
        {
            var customers = new List<Customer>
    {
        new Customer
        {
            Id = 1,
            Name = "Aman Kumar",
            PhoneNo = "9876543210",
            Email = "aman@test.com",
            Vendor = "",
            Center = "Prayagraj Center",
            Status = "Active",
            CreatedAt = DateTime.Now
        },
        new Customer
        {
            Id = 2,
            Name = "Neha Sharma",
            PhoneNo = "9123456780",
            Email = "neha@test.com",
            Vendor = "",
            Center = "Varanasi Center",
            Status = "Active",
            CreatedAt = DateTime.Now
        },
        new Customer
        {
            Id = 3,
            Name = "Rohit Verma",
            PhoneNo = "9012345678",
            Email = "rohit@test.com",
            Vendor = "",
            Center = "Lucknow Center",
            Status = "Active",
            CreatedAt = DateTime.Now
        },
        new Customer
        {
            Id = 4,
            Name = "Priya Singh",
            PhoneNo = "8899001122",
            Email = "priya@test.com",
            Vendor = "",
            Center = "Prayagraj Center",
            Status = "Inactive",
            CreatedAt = DateTime.Now
        },
        new Customer
        {
            Id = 5,
            Name = "Suresh Yadav",
            PhoneNo = "7788990011",
            Email = "suresh@test.com",
            Vendor = "",
            Center = "Varanasi Center",
            Status = "Active",
            CreatedAt = DateTime.Now
        }
    };

            return View(customers);
        }
        public IActionResult Create()
        {

            //ViewBag.Centers = _context.Centers.ToList();
            {
                new SelectListItem { Value = "1", Text = "Prayagraj Center" };
                new SelectListItem { Value = "2", Text = "Varanasi Center" };
                new SelectListItem { Value = "3", Text = "Lucknow Center" };
    };
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
        //ViewBag.Centers = _context.Centers.ToList();
        return View(customer);
    }
    customer.CreatedAt = DateTime.Now;
    customer.Status = "Active";

    //_context.Customers.Add(customer);
    //_context.SaveChanges();

    return RedirectToAction("Index");
}
        //public IActionResult Details(int id)
        //{
            //var customer = _context.Customers.Find(id);

            //    if (customer == null)
            //        return NotFound();

            //    return View(customer);
            //}

            //public async Task<IActionResult> Edit(int id)
            //{
            //    //var customer = await _context.Customers.FindAsync(id);

            //    if (customer == null)
            //        return NotFound();

            //    return View(customer);
            //}

            //[HttpPost]
            //public async Task<IActionResult> Edit(int id, Customer customer)
            //{
            //    if (id != customer.Id)
            //        return NotFound();

            //    //if (ModelState.IsValid)
            //    //{
            //    //    _context.Update(customer);
            //    await _context.SaveChangesAsync();

            //    return RedirectToAction(nameof(Index));
            //}

            //    return View(customer);
            //}
            //public async Task<IActionResult> Delete(int id)
            //{
            //    var customer = await _context.Customers
            //        .FirstOrDefaultAsync(x => x.Id == id);

            //    if (customer == null)
            //        return NotFound();

            //    return View(customer);
            //}

            //    [HttpPost, ActionName("Delete")]
            //    public async Task<IActionResult> DeleteConfirmed(int id)
            //    {
            //        var customer = await _context.Customers.FindAsync(id);

            //        _context.Customers.Remove(customer);

            //        await _context.SaveChangesAsync();

            //        return RedirectToAction(nameof(Index));
            //    }
        
    }
}
