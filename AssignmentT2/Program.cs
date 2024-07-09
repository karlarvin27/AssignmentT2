
using AssignmentT2.DataAccess.Repository;
using AssignmentT2.DataAccess.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using AssignmentT2.DataAccess.Data;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews()
    .AddJsonOptions(options =>  //newly added
    {
        options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve;
        options.JsonSerializerOptions.MaxDepth = 64; // You can adjust the depth limit if needed
    });

builder.Services.AddDbContext<AssignmentT2.DataAccess.Data.ApplicationDbContext>(options=> 
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddDefaultIdentity<IdentityUser>().AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddRazorPages();

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
var app = builder.Build();

ApplyMigrations(app);

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();
app.MapRazorPages();
app.MapControllerRoute(
    name: "default",
    pattern: "{area=Customer}/{controller=Home}/{action=Index}/{id?}");

app.Run();

void ApplyMigrations(IHost app)
{
    using var scope = app.Services.CreateScope();

    var services = scope.ServiceProvider;

    try
    {
        var context = services.GetRequiredService<AssignmentT2.DataAccess.Data.ApplicationDbContext>();
        context.Database.Migrate();
    }
    catch (Exception ex)
    {
        var logger = services.GetRequiredService<ILogger<Program>>();
        logger.LogError(ex, "An occured while migrating the database.");
    }
}