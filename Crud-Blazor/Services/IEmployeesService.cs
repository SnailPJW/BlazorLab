using Crud_Blazor.Models;

namespace Crud_Blazor.Services
{
    public interface IEmployeesService
    {
        public Task<IEnumerable<Employee>> GetAsync();
        public Task<Employee> GetAsync(int id);
        public Task<Employee> Add(Employee employee);
        public Task<bool> Update(int id, Employee employee);
        public Task<bool> Del(int id);
    }
}