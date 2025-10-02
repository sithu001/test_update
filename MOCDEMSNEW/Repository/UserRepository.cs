using Microsoft.EntityFrameworkCore;
using MOCDEMSNEW.Data;
using MOCDEMSNEW.Models;

namespace MOCDEMSNEW.Repository
{
    public class UserRepository: IUserRepository
    {
        private readonly DemsContext _context;

        public UserRepository(DemsContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Employee employee)
        {
            _context.Employees.AddAsync(employee);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Employee>> GetAllAsync()
        {
            return await _context.Employees.ToListAsync();
        }

        public async Task<Employee?> GetByEmailAsync(string email)
        {
            return await _context.Employees.FirstOrDefaultAsync(e => e.EEmail == email);
        }

        public async Task<Employee?> GetByIdAsync(int id)
        {
            return await _context.Employees.FindAsync(id);
        }

        public async Task UpdateAsync(Employee employee)
        {
            _context.Employees.Update(employee);
            await _context.SaveChangesAsync();
        }
    }
}
