using BethanysPieShopHRM.Shared;
using Microsoft.AspNetCore.Components;

namespace Shop.app.Pages
{
    public class IndexBase : ComponentBase 
    {
        public Employee employee { get; set;  }
        protected override Task  OnInitializedAsync()
        {
            employee = new Employee
            {
                FirstName = "Brithany ",
                LastName = "Smith",
            };
            return base.OnInitializedAsync();
        }
        public void Button_Click()
        {
            employee.FirstName = " Gill"; 
        }
    }
}
