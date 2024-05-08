using Advertisement_Portal_ASP_NET_MVC.Infrastructure.Persistance;
using Microsoft.EntityFrameworkCore;
using Advertisement_Portal_ASP_NET_MVC.Infrastructure.Extensions;
using Advertisement_Portal_ASP_NET_MVC.Application.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddApplication();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Load/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Load}/{action=Index}/{id?}");

app.Run();
