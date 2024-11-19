using MedManagement.Models;
using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(User user)
    {
        if (ModelState.IsValid)
        {
            // Thực hiện lưu user vào cơ sở dữ liệu (nếu cần)
            return RedirectToAction("Index");
        }
        return View(user);
    }
}
