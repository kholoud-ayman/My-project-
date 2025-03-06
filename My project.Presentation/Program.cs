using Microsoft.AspNetCore.Razor.Language.Intermediate;
using MyProject.Business.Services;
using MyProject.DataAccess;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<ProjectService>();
builder.Services.AddScoped<ProjectDTO>();

builder.Services.AddControllersWithViews();
var app = builder.Build();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Project}/{action=Index}/{id?}");

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
CSharp
app.Run();
