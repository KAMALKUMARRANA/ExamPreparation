using BlazorServerApp.Services;
using ClassLibrary.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorServerApp.Components.Pages
{
    public partial class EmployeeDetailsBase:ComponentBase
    {
        [Inject]
        public IEmployeeService EmployeeService { get; set; }

        [Parameter]
        public string Id { get; set; }

        public Employee Employee { get; set; }

        protected async override Task OnInitializedAsync()
        {
          Employee=await EmployeeService.GetEmployeeById(int.Parse(Id));
        }

    }
}
