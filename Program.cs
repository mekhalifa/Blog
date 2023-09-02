using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;



// Services Configuration

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();


// Configuration
var app = builder.Build();
app.UseRouting();
app.MapControllerRoute(
        name:"default",
        pattern:"{controller=Home}/{action=Index}/{id?}");


app.Run();
