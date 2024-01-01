using BlazorServerApp.Services;
using ClassLibrary.Models;
using EFCoreTutorials.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorServerApp.Components.Pages
{
    public  class EditEmployeeBase : ComponentBase
    {
        public Employee Employee { get; set; } = new Employee();
        public UpdatedEmployee updatedEmployee { get; set; } = new UpdatedEmployee(); 

        [Inject]
        public IEmployeeService EmployeeService { get; set; }

        [Parameter]
        public string Id { get; set; }

        protected async override Task OnInitializedAsync()
        {
            Employee = await EmployeeService.GetEmployeeById(int.Parse(Id));
            updatedEmployee.FirstName = Employee.FirstName;
            updatedEmployee.LastName = Employee.LastName;
            updatedEmployee.Email = Employee.Email;
            updatedEmployee.Gender = Employee.Gender;
            updatedEmployee.DateOfBrith=Employee.DateOfBrith;
            updatedEmployee.PhotoPath = Employee.PhotoPath;
            

        }
        protected async Task HandleValidSubmit()
        {
            Employee.FirstName = updatedEmployee.FirstName;
            Employee.LastName = updatedEmployee.LastName;
            Employee.Email = updatedEmployee.Email;
            Employee.Gender = updatedEmployee.Gender;
            Employee.DateOfBrith = updatedEmployee.DateOfBrith;
            Employee.PhotoPath = updatedEmployee.PhotoPath;

            var result = await EmployeeService.UpdateEmployee(Employee.EmployeeId, Employee);
            /* if (result != null)
             {
                 NavigationManager.NavigateTo("/");
             }*/
        }
    }
}
