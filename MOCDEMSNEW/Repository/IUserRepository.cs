using MOCDEMSNEW.Models;

namespace MOCDEMSNEW.Repository
{
    public interface IUserRepository
    {
        Task<Employee?> GetByEmailAsync(string email);

        Task<Employee?> GetByIdAsync(int id);

        Task<IEnumerable<Employee>> GetAllAsync();

        Task AddAsync(Employee employee);

        Task UpdateAsync(Employee employee);
    }
}
