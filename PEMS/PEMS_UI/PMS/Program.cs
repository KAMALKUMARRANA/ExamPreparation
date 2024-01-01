
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using PEMS_UI.Data;
using PEMS_UI.Services;
using Syncfusion.Blazor;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();


var connectionString = builder.Configuration.GetConnectionString("dbcs");

builder.Services.AddDbContext<DataContext>(option => option.UseSqlServer(connectionString),optionsLifetime:ServiceLifetime.Singleton);
builder.Services.AddDbContextFactory<DataContext>(option => option.UseSqlServer(connectionString));
builder.Services.AddIdentity<IdentityUser, IdentityRole>(
    options =>
    {
        options.Password.RequireDigit = false;
        options.Password.RequireLowercase = false;
        options.Password.RequireUppercase = false;
        options.Password.RequiredLength = 5;
        options.Password.RequireNonAlphanumeric = false;
        options.SignIn.RequireConfirmedPhoneNumber = false;
    })
    
    .AddEntityFrameworkStores<DataContext>();
builder.Services.AddScoped<IEmployeeService, EmployeeService>();


var app = builder.Build();
using (var scope = app.Services.CreateScope())
{
    var dbContext=scope.ServiceProvider.GetRequiredService<DataContext>();
    dbContext.Database.EnsureCreated();
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
