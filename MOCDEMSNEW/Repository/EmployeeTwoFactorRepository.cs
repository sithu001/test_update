using MOCDEMSNEW.Data;
using MOCDEMSNEW.Models;

namespace MOCDEMSNEW.Repository
{
    public class EmployeeTwoFactorRepository:IEmployeeTwoFactorRepository
    {
        private readonly DemsContext _context;

        public EmployeeTwoFactorRepository(DemsContext context)
        {
            _context = context;
        }

        public Task AddAsync(EmployeeTwoFactor twoFactor)
        {
            throw new NotImplementedException();
        }

        public Task<EmployeeTwoFactor?> GetByEmployeeIdAsync(int employeeId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(EmployeeTwoFactor twoFactor)
        {
            throw new NotImplementedException();
        }
    }
}
