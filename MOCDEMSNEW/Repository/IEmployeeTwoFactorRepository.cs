using MOCDEMSNEW.Models;

namespace MOCDEMSNEW.Repository
{
    public interface IEmployeeTwoFactorRepository
    {
        Task<EmployeeTwoFactor?> GetByEmployeeIdAsync(int employeeId);
        Task AddAsync(EmployeeTwoFactor twoFactor);
        Task UpdateAsync(EmployeeTwoFactor twoFactor);
    }
}
