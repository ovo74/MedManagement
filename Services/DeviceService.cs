using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MedManagement.Data;
using MedManagement.Models;
using Microsoft.EntityFrameworkCore;
using MedManagement.Data;
using MedManagement.Models;

namespace MedManagement.Services
{
    public class DeviceService
    {
        private readonly ApplicationDbContext _context;

        public DeviceService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Device>> GetAllDevicesAsync()
        {
            return await _context.Devices.ToListAsync();
        }

        public async Task<Device> GetDeviceByIdAsync(int id)
        {
            return await _context.Devices.FindAsync(id);
        }

        public async Task AddDeviceAsync(Device device)
        {
            _context.Devices.Add(device);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateDeviceAsync(Device device)
        {
            _context.Devices.Update(device);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteDeviceAsync(int id)
        {
            var device = await _context.Devices.FindAsync(id);
            if (device != null)
            {
                _context.Devices.Remove(device);
                await _context.SaveChangesAsync();
            }
        }
    }
}
