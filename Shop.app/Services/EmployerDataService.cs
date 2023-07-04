using BethanysPieShopHRM.Shared;
using System.Text.Json;

namespace Shop.app.Services
{
    public class EmployerDataService : IEmployerDataService
    {
        private readonly HttpClient _HttpClient = default!;

        public EmployerDataService(HttpClient httpClient)
        {
            _HttpClient = httpClient;
        }

        public Task<Employee> AddEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public Task DeleteEmployee(int employeeID)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Employee>> GetAllEmployees()
        {
            //It means that the Deserializer will convert the Stream Data into an IEnumerable of Employee ! 
            return await JsonSerializer.DeserializeAsync<IEnumerable<Employee>>(await _HttpClient.GetStreamAsync($"api/Employee"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true  }); 
            
        }
        // PropertyNameCaseInsensitive , it should be false so the method can work properly 
        public async Task<Employee> GetEmployeeDetails(int employeeId)
        {
            return await JsonSerializer.DeserializeAsync<Employee>(await _HttpClient.GetStreamAsync($"api/Employee/{employeeId}"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true  });

        }

        public Task UpdateEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
