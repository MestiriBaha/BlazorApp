using BethanysPieShopHRM.Shared;

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

        public Task<IEnumerable<Employee>> GetAllEmployees()
        {
            throw new NotImplementedException();
        }

        public Task<Employee> GetEmployeeDetails(int employeeId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
