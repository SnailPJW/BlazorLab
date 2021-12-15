using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Crud_Blazor.Models;

namespace Crud_Blazor.Services
{
    public class EmployeesService : IEmployeesService
    {
        private readonly IHttpClientFactory _clientFactory;
        private readonly HttpClient _httpClient;
        public EmployeesService(IHttpClientFactory clientFactory)
        {
        _clientFactory = clientFactory;
        _httpClient = _clientFactory.CreateClient("ServerAPI");
        }
        public async Task<IEnumerable<Employee>> GetAsync()
        {
        var obj = await
        _httpClient.GetFromJsonAsync<IEnumerable<Employee>>("api/Employees/");
        return obj;
        }
        public async Task<Employee> GetAsync(int id)
        {
        var obj = await _httpClient.GetFromJsonAsync<Employee>
        ($"api/Employees/{id}");
        return obj;
        }
        public async Task<Employee> Add(Employee employee)
        {
        var result = await _httpClient.PostAsJsonAsync<Employee>
        ($"api/Employees/", employee);
        var obj = await result.Content.ReadFromJsonAsync<Employee>();
        return obj;
        }
        public async Task<bool> Update(int id, Employee employee)
        {
        await _httpClient.PutAsJsonAsync<Employee>
        ($"api/Employees/{id}", employee);
        return true;
        }
        public async Task<bool> Del(int id)
        {
        var result = await
        _httpClient.DeleteAsync($"api/Employees/{id}");
        return true;
        }
    }
    
}