using Microsoft.EntityFrameworkCore;
using RecipeWebApp.Models;
using Microsoft.Extensions.Configuration;
using RecipeWebApp.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContextPool<PlatefulContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("PlatefulSimplyMsSQLString")));
builder.Services.AddScoped<IPlateful, PlatefulSql>();
builder.Services.AddScoped<IUserService, UserService>();
//builder.Services.AddSingleton<IRecipeService, RecipeService>();

var app = builder.Build();

//Ensuring the daatabase is created
//using (var scope = app.Services.CreateScope())
//{
//    var context = scope.ServiceProvider.GetRequiredService<PlatefulContext>();
//    context.Database.EnsureCreated();
//}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}

app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();
app.MapRazorPages()
   .WithStaticAssets();

app.Run();
