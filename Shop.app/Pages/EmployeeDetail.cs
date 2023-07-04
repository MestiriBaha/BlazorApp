using BethanysPieShopHRM.Shared;
using Microsoft.AspNetCore.Components;
using Shop.app.Services;

namespace Shop.app.Pages
{
	
	public partial  class EmployeeDetail
    {
        [Parameter]
		public String?  EmployeeId { get; set; }
		public Employee Employee { get; set;  } = new Employee();
		[Inject]
		public IEmployerDataService _DataService { get; set;  }
		protected async  override Task OnInitializedAsync()
		{

			Employee = (await _DataService.GetEmployeeDetails(int.Parse(EmployeeId))) ; 
		}

		public IEnumerable<Employee>? Employees { get; set; }



		

	


	}
}
