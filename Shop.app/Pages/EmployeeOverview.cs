using BethanysPieShopHRM.Shared;
using Microsoft.AspNetCore.Components;
using Shop.app.Services;

namespace Shop.app.Pages
{
    public partial  class EmployeeOverview
    {
		public IEnumerable<Employee>? Employees { get; set; }
		//Inject works now because our IEmployerDataService is already Registered with a dependancy Injection Container !  
        [Inject]
		public IEmployerDataService DataService { get; set;  }
		protected async override Task OnInitializedAsync()
        {
			Employees = (await DataService.GetAllEmployees()).ToList() ; 

			  base.OnInitializedAsync(); 
        }

		


	}
}
