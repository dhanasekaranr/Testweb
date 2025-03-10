using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BvlWeb.Services.Data.Entities;
using BvlWeb.Services.Data.DbContexts;

namespace BvlWeb.Services.Data.Repositories
{
    public class CommonRepository
    {
        private readonly DataContext _context;

        public CommonRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<UserEntity> GetUserByIdAsync(int id)
        {
            return await _context.Users.FindAsync(id);
        }
    }
}
