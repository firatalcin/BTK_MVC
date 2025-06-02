using Microsoft.EntityFrameworkCore;
using Store.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<RepositoryContext>(opt =>
{
    opt.UseSqlite(builder.Configuration.GetConnectionString("sqlconnection"));
});
var app = builder.Build();


app.UseStaticFiles();
app.UseHttpsRedirection();
app.UseRouting();

app.MapControllerRoute(
    "default",
    "{controller=Product}/{action=Index}/{id?}");

app.Run();