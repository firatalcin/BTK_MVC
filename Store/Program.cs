var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/btk", () => "BTK Akademi");

app.UseHttpsRedirection();
app.UseRouting();

app.MapControllerRoute(
    "default", 
    "{controller=Home}/{action=Index}/{id?}");

app.Run();