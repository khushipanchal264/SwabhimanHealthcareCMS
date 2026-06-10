using Microsoft.AspNetCore.Mvc;
using SwabhimanHealthcareCMS.Data;
using SwabhimanHealthcareCMS.Models;
using SwabhimanHealthcareCMS.Data;
using SwabhimanHealthcareCMS.Models;

public class DashboardController : Controller
{
    private readonly ApplicationDbContext _context;

    public DashboardController(ApplicationDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        DashboardViewModel vm =
            new DashboardViewModel();

        vm.TotalCustomers =
            _context.Customers.Count();

        vm.ApprovedCards =
            _context.Cards.Count(x =>
                x.Status == "approved");

        vm.PendingCards =
            _context.Cards.Count(x =>
                x.Status == "pending");

        vm.RejectedCards =
            _context.Cards.Count(x =>
                x.Status == "rejected");

        return View(vm);
    }
}