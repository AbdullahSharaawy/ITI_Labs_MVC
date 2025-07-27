using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Sharaawy_BL.ImplementServices;
using Sharaawy_BL.Services;
using Sharaawy_DAL;
using Sharaawy_DAL.DataBase;
using Sharaawy_DAL.Enterfaces;
using Sharaawy_DAL.Entities;
using Sharaawy_DAL.ImplementInterfaces;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
var con = builder.Configuration.GetConnectionString("DefaultConnection");

//builder.Services.AddDbContext<SharaawyContext>(options => options.UseSqlServer(con));
builder.Services.AddDbContext<SharaawyContext>(options =>
options.UseLazyLoadingProxies().UseSqlServer(
        con,
        b => b.MigrationsAssembly("Sharaawy_DAL")  // Specify migrations assembly here
    )
);
builder.Services.AddScoped < ICRUD<Course>, CourseCRUD>();
builder.Services.AddScoped<ICRUD<Instructor>, InstructorCRUD>();
builder.Services.AddScoped<ICRUD<Department>, DepartmentCRUD>();

builder.Services.AddScoped<ICourseService, CourseService>();
builder.Services.AddScoped<IDepartmentService, DepartmentService>();
builder.Services.AddScoped<IInstructorService, InstructorService>();


var app = builder.Build(); 

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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
