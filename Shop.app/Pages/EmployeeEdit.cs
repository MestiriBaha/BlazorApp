using BethanysPieShopHRM.Shared;
using Microsoft.AspNetCore.Components;
using Shop.app.Services;

namespace Shop.app.Pages
{
    public partial class EmployeeEdit
    {
        [Inject]
        public EmployerDataService _EmployerDataService { get; set;  }
        [Parameter]
        public String EmployeeId { get; set; }
        //the employee where we will be doing the data binding ! 
        private  Employee Employee = new Employee();
        protected override async Task OnInitializedAsync()
        {
            Employee = await _EmployerDataService.GetEmployeeDetails(int.Parse(EmployeeId)); 
                base.OnInitializedAsync();
        }
    }
}
