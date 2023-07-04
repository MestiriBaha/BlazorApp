using BethanysPieShopHRM.Shared;

namespace Shop.app.Services
{
    public interface IEmployerDataService
    {
        Task<IEnumerable<Employee>> GetAllEmployees(); 
        Task<Employee> GetEmployeeDetails(int employeeId);  
        Task<Employee> AddEmployee(Employee employee); 
        Task UpdateEmployee(Employee employee);
        Task DeleteEmployee(int employeeID);
    }
}
