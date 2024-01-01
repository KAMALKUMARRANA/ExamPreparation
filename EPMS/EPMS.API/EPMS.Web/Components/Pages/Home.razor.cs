using EPMS.Web.Models;
using EPMS.Web.Repository;

using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace EPMS.Web.Components.Pages
{
    public partial class Home
    {
        [Inject]
        public IJSRuntime JSRuntime { get; set; }
        [Inject]
        public  IUserRepository UserRepository { get; set; }
        public IEnumerable<User> user { get; set; }
        public bool _showSearchClear = true;

        public async Task  showAlert()
        {
          await  JSRuntime.InvokeVoidAsync("alert", "Welcome");
        }
        protected async override void OnInitialized()
        {
            user= await UserRepository.GetUser();
        }
        public void ClearSearch()
        {

        }
    }
}
