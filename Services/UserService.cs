using System.Collections.Generic;
using System.Threading.Tasks;
using MedManagement.Data;
using MedManagement.Models;
using Microsoft.EntityFrameworkCore;
using MedManagement.Data;
using MedManagement.Models;

namespace MedManagement.Services
{
    public class UserService
    {
        private readonly ApplicationDbContext _context;

        public UserService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<User>> GetAllUsersAsync()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task AddUserAsync(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
        }

        // Các phương thức khác như cập nhật và xóa người dùng nếu cần.
    }
}
