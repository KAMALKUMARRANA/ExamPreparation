using Blazorise;
using EPMS.Web.Components;
using Blazorise.Bootstrap;
using Blazorise.Icons.FontAwesome;
using Syncfusion.Blazor;
using Microsoft.EntityFrameworkCore;
using EPMS.Web.Models;
using EPMS.Web.Data;

using EPMS.Web.Repository;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services
    .AddBlazorise(options =>
    {
        options.Immediate = true;
    })
    .AddBootstrapProviders()
    .AddFontAwesomeIcons();
var config = builder.Configuration.GetConnectionString("dbcs");
builder.Services.AddDbContext<DataBaseContext>(opt => opt.UseSqlServer(config));
builder.Services.AddScoped<IUserRepository,UserRepository>();
builder.Services.AddSyncfusionBlazor();
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("ryan@offdutytx.com/qnq4hek_pgf7xfv9JAE");

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
