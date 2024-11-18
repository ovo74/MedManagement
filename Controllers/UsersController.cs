using System.Threading.Tasks;
using MedManagement.Models;
using Microsoft.AspNetCore.Mvc;
using MedManagement.Services;

namespace MedManagement.Controllers
{
    public class UsersController : Controller
    {
        private readonly UserService _userService;

        public UsersController(UserService userService)
        {
            _userService = userService;
        }

        public async Task<IActionResult> Index()
        {
            var users = await _userService.GetAllUsersAsync();
            return View(users);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(User user)
        {
            if (ModelState.IsValid)
            {
                await _userService.AddUserAsync(user);
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }
    }
}
