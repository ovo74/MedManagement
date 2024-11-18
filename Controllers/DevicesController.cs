using System.Threading.Tasks;
using MedManagement.Models;
using Microsoft.AspNetCore.Mvc;
using MedManagement.Services;

namespace MedManagement.Controllers
{
    public class DevicesController : Controller
    {
        private readonly DeviceService _deviceService;

        public DevicesController(DeviceService deviceService)
        {
            _deviceService = deviceService;
        }

        public async Task<IActionResult> Index()
        {
            var devices = await _deviceService.GetAllDevicesAsync();
            return View(devices);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Device device)
        {
            if (ModelState.IsValid)
            {
                await _deviceService.AddDeviceAsync(device);
                return RedirectToAction(nameof(Index));
            }
            return View(device);
        }

        // Các phương thức Edit, Delete...
    }
}
