using ClassLibrary.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorServerApp.Components.Pages
{
    public class DisplayEmployeeBase:ComponentBase
    {
        [Parameter]
        public Employee emp { get; set; }
        [Parameter]
        public bool ShowFooter { get; set; }
    }
}
